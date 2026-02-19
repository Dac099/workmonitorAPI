using System.ComponentModel.DataAnnotations;

namespace workmonitorAPI.DTOs.TableValueDTOs;

public record GetDefinedValuesDto(
    [Required] string ColumnType
);
