namespace workmonitorAPI.DTOs.TableValueDTOs;

public record TableValueWithTypeDto(
    Guid Id,
    Guid? ItemId,
    Guid ColumnId,
    string? Value,
    string ColumnType
);