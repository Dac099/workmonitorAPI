using System.Collections.Generic;
using workmonitorAPI.DTOs.ItemDTOs;
namespace workmonitorAPI.DTOs.GroupDTOs;

public record GroupDetailDto(
    Guid Id,
    Guid BoardId,
    string Name,
    int Position,
    string? Color,
    IEnumerable<ItemWithValuesDto> Items
);
