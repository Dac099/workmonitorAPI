using System.ComponentModel.DataAnnotations;

namespace workmonitorAPI.DTOs.ColumnDTOs;

public record UpdateColumnDto(
    [MaxLength(100)] string? Name,
    [MaxLength(255)] string? Settings,
    int? Position,
    int? ColumnWidth
);
