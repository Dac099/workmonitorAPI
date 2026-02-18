using System.ComponentModel.DataAnnotations;

namespace workmonitorAPI.DTOs.TableValueDTOs;

public record CreateTableValueDto(
    Guid? ItemId,
    [Required] Guid ColumnId,
    string? Value = null
);
