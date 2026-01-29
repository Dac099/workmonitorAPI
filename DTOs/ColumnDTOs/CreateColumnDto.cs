using System.ComponentModel.DataAnnotations;

namespace workmonitorAPI.DTOs.ColumnDTOs;

public record CreateColumnDto(
    [Required] Guid BoardId,
    [Required][MaxLength(100)] string Name,
    [Required][MaxLength(50)] string Type,
    [MaxLength(255)]string? Settings = null,
    int? ColumnWidth = null
);
