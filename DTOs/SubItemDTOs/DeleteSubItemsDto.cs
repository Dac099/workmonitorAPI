using System.Collections.Generic;

namespace workmonitorAPI.DTOs.SubItemDTOs;

public record DeleteSubItemsDto(
    IEnumerable<Guid> SubItemIds
);
