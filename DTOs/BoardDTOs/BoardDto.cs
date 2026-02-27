using System;

namespace workmonitorAPI.DTOs.BoardDTOs;

public record BoardDto(
    Guid Id,
    Guid WorkspaceId,
    string Name,
    string? Description,
    bool HasTimeline
);
