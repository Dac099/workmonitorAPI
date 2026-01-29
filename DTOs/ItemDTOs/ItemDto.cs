namespace workmonitorAPI.DTOs.ItemDTOs;

public record ItemDto(
    Guid Id,
    Guid GroupId,
    string Name,
    int Position,
    string? ProjectId
);
