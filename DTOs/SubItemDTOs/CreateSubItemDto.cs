namespace workmonitorAPI.DTOs.SubItemDTOs;

public record CreateSubItemDto(
    string Name,
    Guid ItemParent
);
