using System.Collections.Generic;
using workmonitorAPI.DTOs.TableValueDTOs;

namespace workmonitorAPI.DTOs.SubItemDTOs;

public record SubItemWithValuesDto(
    Guid Id,
    Guid ItemParent,
    string Name,
    IEnumerable<TableValueWithTypeDto> Values
);
