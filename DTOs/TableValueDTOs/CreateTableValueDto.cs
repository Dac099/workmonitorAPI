using System.ComponentModel.DataAnnotations;

namespace workmonitorAPI.DTOs.TableValueDTOs;

public record CreateTableValueDto(
    [Required] Guid ItemId,
    [Required] Guid ColumnId,
    string? Value = null
);
