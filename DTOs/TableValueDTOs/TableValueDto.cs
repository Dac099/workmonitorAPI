namespace workmonitorAPI.DTOs.TableValueDTOs;

public record TableValueDto(
    Guid Id,
    Guid? ItemId,
    Guid ColumnId,
    string? Value
);
