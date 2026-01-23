using System.ComponentModel.DataAnnotations;

namespace workmonitorAPI.DTOs.WorkspaceDTOs;

public record UpdateWorkspaceDto(
    [Required][MaxLength(100)]string Name,
    [MaxLength(255)]string? Description
);
