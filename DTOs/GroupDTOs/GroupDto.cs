namespace workmonitorAPI.DTOs.GroupDTOs;

public record GroupDto(
    Guid Id,
    Guid BoardId,
    string Name,
    int Position,
    string? Color
);
