using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using workmonitorAPI.Data;
using workmonitorAPI.DTOs.BoardDTOs;
using workmonitorAPI.Services.Interfaces;

namespace workmonitorAPI.Services;

public class ExportService : IExportService
{
    private readonly AppDbContext _db;

    public ExportService(AppDbContext db)
    {
        _db = db;
    }

    public async Task<byte[]> ExportBoardToExcelAsync(Guid boardId, ExportBoardDto exportDto)
    {
        // Verificar que el tablero existe
        var board = await _db.Boards
            .AsNoTracking()
            .FirstOrDefaultAsync(b => b.Id == boardId && b.DeletedAt == null)
            ?? throw new KeyNotFoundException("Board not found");

        using var workbook = new XLWorkbook();
        var usedSheetNames = new HashSet<string>(); // Rastrear nombres de hojas usadas

        // Obtener columnas seleccionadas
        var columns = await _db.Columns
            .AsNoTracking()
            .Where(c => c.BoardId == boardId 
                && c.DeletedAt == null 
                && exportDto.ColumnIds.Contains(c.Id))
            .OrderBy(c => c.Position)
            .ToListAsync();

        // Crear una hoja por cada grupo
        foreach (var groupId in exportDto.GroupIds)
        {
            var group = await _db.Groups
                .AsNoTracking()
                .FirstOrDefaultAsync(g => g.Id == groupId && g.DeletedAt == null);

            if (group == null) continue;

            var items = await _db.Items
                .AsNoTracking()
                .Where(i => i.GroupId == groupId && i.DeletedAt == null)
                .OrderBy(i => i.Position)
                .ToListAsync();

            var itemIds = items.Select(i => i.Id).ToList();

            var tableValues = await _db.TableValues
                .AsNoTracking()
                .Where(tv => tv.ItemId != null 
                    && itemIds.Contains(tv.ItemId.Value) 
                    && tv.DeletedAt == null
                    && exportDto.ColumnIds.Contains(tv.ColumnId))
                .ToListAsync();

            // Crear la hoja para el grupo con nombre único
            var sheetName = GetUniqueSheetName(group.Name, usedSheetNames);
            var worksheet = workbook.Worksheets.Add(sheetName);

            // Agregar encabezados
            worksheet.Cell(1, 1).Value = "Item";
            worksheet.Cell(1, 1).Style.Font.Bold = true;
            worksheet.Cell(1, 1).Style.Fill.BackgroundColor = XLColor.LightGray;

            for (int i = 0; i < columns.Count; i++)
            {
                worksheet.Cell(1, i + 2).Value = columns[i].Name;
                worksheet.Cell(1, i + 2).Style.Font.Bold = true;
                worksheet.Cell(1, i + 2).Style.Fill.BackgroundColor = XLColor.LightGray;
            }

            // Agregar datos de items
            int row = 2;
            foreach (var item in items)
            {
                worksheet.Cell(row, 1).Value = item.Name;

                for (int col = 0; col < columns.Count; col++)
                {
                    var column = columns[col];
                    var value = tableValues.FirstOrDefault(tv => tv.ItemId == item.Id && tv.ColumnId == column.Id);

                    if (value?.Value != null)
                    {
                        FormatCellValue(worksheet.Cell(row, col + 2), value.Value, column.Type);
                    }
                }

                row++;
            }

            // Ajustar ancho de columnas
            worksheet.Columns().AdjustToContents();
        }

        // Crear hoja de Gantt si se solicitó y el tablero tiene columnas de timeline
        if (exportDto.IncludeGantt)
        {
            var hasTimeline = await _db.Columns
                .AsNoTracking()
                .AnyAsync(c => c.BoardId == boardId && c.Type == "timeline" && c.DeletedAt == null);

            if (hasTimeline)
            {
                await CreateGanttSheet(workbook, boardId, exportDto.GroupIds, exportDto.ColumnIds);
            }
        }

        // Convertir a bytes
        using var stream = new MemoryStream();
        workbook.SaveAs(stream);
        return stream.ToArray();
    }

    private void FormatCellValue(IXLCell cell, string value, string columnType)
    {
        switch (columnType)
        {
            case "status":
                try
                {
                    var statusData = JsonSerializer.Deserialize<Dictionary<string, string>>(value);
                    if (statusData != null && statusData.TryGetValue("text", out var text))
                    {
                        cell.Value = text;
                        if (statusData.TryGetValue("color", out var color) && !string.IsNullOrEmpty(color))
                        {
                            // Convertir color hex a XLColor
                            var xlColor = XLColor.FromHtml(color);
                            cell.Style.Fill.BackgroundColor = xlColor;
                            
                            // Calcular contraste y establecer color de texto
                            var brightness = GetBrightness(color);
                            cell.Style.Font.FontColor = brightness > 128 ? XLColor.Black : XLColor.White;
                        }
                    }
                }
                catch
                {
                    cell.Value = value;
                }
                break;

            case "timeline":
                try
                {
                    var dates = JsonSerializer.Deserialize<string[]>(value);
                    if (dates != null && dates.Length >= 2)
                    {
                        var startDate = DateTime.Parse(dates[0]);
                        var endDate = DateTime.Parse(dates[1]);
                        cell.Value = $"{startDate:dd/MM/yyyy} - {endDate:dd/MM/yyyy}";
                    }
                }
                catch
                {
                    cell.Value = value;
                }
                break;

            case "date":
                try
                {
                    var date = DateTime.Parse(value);
                    cell.Value = date;
                    cell.Style.DateFormat.Format = "dd/MM/yyyy";
                }
                catch
                {
                    cell.Value = value;
                }
                break;

            case "number":
                if (double.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out var number))
                {
                    cell.Value = number;
                }
                else
                {
                    cell.Value = value;
                }
                break;

            default: // text
                cell.Value = value;
                break;
        }
    }

    private int GetBrightness(string hexColor)
    {
        try
        {
            // Remover # si existe
            hexColor = hexColor.TrimStart('#');
            
            // Convertir a RGB
            int r = Convert.ToInt32(hexColor.Substring(0, 2), 16);
            int g = Convert.ToInt32(hexColor.Substring(2, 2), 16);
            int b = Convert.ToInt32(hexColor.Substring(4, 2), 16);
            
            // Calcular brillo
            return (int)Math.Sqrt(r * r * 0.299 + g * g * 0.587 + b * b * 0.114);
        }
        catch
        {
            return 128; // Valor medio por defecto
        }
    }

    private async Task CreateGanttSheet(XLWorkbook workbook, Guid boardId, List<Guid> groupIds, List<Guid> columnIds)
    {
        var worksheet = workbook.Worksheets.Add("Gantt Chart");

        // Obtener la primera columna de timeline del tablero
        var timelineColumn = await _db.Columns
            .AsNoTracking()
            .Where(c => c.BoardId == boardId && c.Type == "timeline" && c.DeletedAt == null)
            .OrderBy(c => c.Position)
            .FirstOrDefaultAsync();

        if (timelineColumn == null) return;

        // Encabezados
        worksheet.Cell(1, 1).Value = "Grupo";
        worksheet.Cell(1, 2).Value = "Item";
        worksheet.Cell(1, 3).Value = "Fecha Inicio";
        worksheet.Cell(1, 4).Value = "Fecha Fin";
        worksheet.Cell(1, 5).Value = "Duración (días)";

        for (int i = 1; i <= 5; i++)
        {
            worksheet.Cell(1, i).Style.Font.Bold = true;
            worksheet.Cell(1, i).Style.Fill.BackgroundColor = XLColor.LightGray;
        }

        int row = 2;
        DateTime? minDate = null;
        DateTime? maxDate = null;
        var ganttData = new List<(string Group, string Item, DateTime Start, DateTime End, string Color)>();

        // Recopilar datos para el Gantt
        foreach (var groupId in groupIds)
        {
            var group = await _db.Groups
                .AsNoTracking()
                .FirstOrDefaultAsync(g => g.Id == groupId && g.DeletedAt == null);

            if (group == null) continue;

            var items = await _db.Items
                .AsNoTracking()
                .Where(i => i.GroupId == groupId && i.DeletedAt == null)
                .OrderBy(i => i.Position)
                .ToListAsync();

            var itemIds = items.Select(i => i.Id).ToList();

            var timelineValues = await _db.TableValues
                .AsNoTracking()
                .Where(tv => tv.ItemId != null 
                    && itemIds.Contains(tv.ItemId.Value)
                    && tv.ColumnId == timelineColumn.Id
                    && tv.DeletedAt == null)
                .ToListAsync();

            foreach (var item in items)
            {
                var timelineValue = timelineValues.FirstOrDefault(tv => tv.ItemId == item.Id);
                if (timelineValue?.Value == null) continue;

                try
                {
                    var dates = JsonSerializer.Deserialize<string[]>(timelineValue.Value);
                    if (dates != null && dates.Length >= 2)
                    {
                        var startDate = DateTime.Parse(dates[0]);
                        var endDate = DateTime.Parse(dates[1]);
                        var duration = (endDate - startDate).Days + 1;

                        worksheet.Cell(row, 1).Value = group.Name;
                        worksheet.Cell(row, 2).Value = item.Name;
                        worksheet.Cell(row, 3).Value = startDate;
                        worksheet.Cell(row, 3).Style.DateFormat.Format = "dd/MM/yyyy";
                        worksheet.Cell(row, 4).Value = endDate;
                        worksheet.Cell(row, 4).Style.DateFormat.Format = "dd/MM/yyyy";
                        worksheet.Cell(row, 5).Value = duration;

                        // Actualizar fechas min/max
                        if (minDate == null || startDate < minDate) minDate = startDate;
                        if (maxDate == null || endDate > maxDate) maxDate = endDate;

                        ganttData.Add((group.Name, item.Name, startDate, endDate, group.Color ?? "#3498db"));

                        row++;
                    }
                }
                catch
                {
                    // Ignorar valores inválidos
                }
            }
        }

        // Ajustar columnas
        worksheet.Columns().AdjustToContents();

        // Crear visualización del Gantt usando formato condicional y colores
        if (minDate.HasValue && maxDate.HasValue && ganttData.Count > 0)
        {
            var totalDays = (maxDate.Value - minDate.Value).Days + 1;

            // Agregar encabezados de fechas
            worksheet.Cell(1, 6).Value = "Gantt Visual";
            worksheet.Cell(1, 6).Style.Font.Bold = true;
            worksheet.Cell(1, 6).Style.Fill.BackgroundColor = XLColor.LightGray;

            // Pintar las celdas según el timeline
            row = 2;
            foreach (var data in ganttData)
            {
                var startDay = (data.Start.Date - minDate.Value.Date).Days;
                var endDay = (data.End.Date - minDate.Value.Date).Days;
                
                // Crear una representación visual simple
                var ganttBar = new string('█', Math.Max(1, (endDay - startDay + 1)));
                worksheet.Cell(row, 6).Value = ganttBar;
                
                try
                {
                    var color = XLColor.FromHtml(data.Color);
                    worksheet.Cell(row, 6).Style.Fill.BackgroundColor = color;
                    worksheet.Cell(row, 6).Style.Font.FontColor = XLColor.White;
                }
                catch
                {
                    worksheet.Cell(row, 6).Style.Fill.BackgroundColor = XLColor.Blue;
                    worksheet.Cell(row, 6).Style.Font.FontColor = XLColor.White;
                }
                
                row++;
            }
        }

        worksheet.Columns().AdjustToContents();
    }

    private string SanitizeSheetName(string name)
    {
        // Excel no permite ciertos caracteres en nombres de hojas
        var invalid = new[] { '\\', '/', '*', '[', ']', ':', '?' };
        foreach (var c in invalid)
        {
            name = name.Replace(c, '_');
        }

        // Excel limita los nombres de hojas a 31 caracteres
        if (name.Length > 31)
        {
            name = name.Substring(0, 31);
        }

        return name;
    }

    private string GetUniqueSheetName(string name, HashSet<string> usedNames)
    {
        var sanitized = SanitizeSheetName(name);
        
        // Si el nombre ya existe, agregar un sufijo numérico
        if (usedNames.Contains(sanitized))
        {
            int counter = 1;
            string uniqueName;
            
            do
            {
                // Dejar espacio para el sufijo (_1, _2, etc.)
                var suffix = $"_{counter}";
                var baseName = sanitized.Length + suffix.Length > 31
                    ? sanitized.Substring(0, 31 - suffix.Length)
                    : sanitized;
                
                uniqueName = baseName + suffix;
                counter++;
            } while (usedNames.Contains(uniqueName));
            
            usedNames.Add(uniqueName);
            return uniqueName;
        }
        
        usedNames.Add(sanitized);
        return sanitized;
    }
}
