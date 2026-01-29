namespace workmonitorAPI.DTOs.ColumnDTOs;

public record ColumnDto(
    Guid Id,
    Guid BoardId,
    string Name,
    string Type,
    string? Settings,
    int Position,
    int? ColumnWidth
);
