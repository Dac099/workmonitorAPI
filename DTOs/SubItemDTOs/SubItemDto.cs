namespace workmonitorAPI.DTOs.SubItemDTOs;

public record SubItemDto(
    Guid Id,
    string Name,
    Guid ItemParent
);
