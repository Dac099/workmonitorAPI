using System;
using System.Threading.Tasks;
using workmonitorAPI.DTOs.BoardDTOs;

namespace workmonitorAPI.Services.Interfaces;

public interface IExportService
{
    Task<byte[]> ExportBoardToExcelAsync(Guid boardId, ExportBoardDto exportDto);
}
