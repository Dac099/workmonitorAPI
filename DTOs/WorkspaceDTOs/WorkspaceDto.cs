using System;

namespace workmonitorAPI.DTOs.WorkspaceDTOs;

public record WorkspaceDto(Guid Id, string Name, string? Description);
