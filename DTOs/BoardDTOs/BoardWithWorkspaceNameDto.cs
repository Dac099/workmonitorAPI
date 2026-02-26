using System;

namespace workmonitorAPI.DTOs.BoardDTOs;

public record BoardWithWorkspaceNameDto(
    Guid Id,
    Guid WorkspaceId,
    string WorkspaceName,
    string Name,
    string? Description,
    bool HasTimeline
);
