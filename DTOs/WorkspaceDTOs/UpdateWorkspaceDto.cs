using System.ComponentModel.DataAnnotations;

namespace workmonitorAPI.DTOs.WorkspaceDTOs;

public record UpdateWorkspaceDto(
    [MaxLength(100)]string? Name,
    [MaxLength(255)]string? Description
);
