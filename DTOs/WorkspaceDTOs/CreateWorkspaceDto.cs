using System.ComponentModel.DataAnnotations;

namespace workmonitorAPI.DTOs.WorkspaceDTOs;

public record CreateWorkspaceDto(
    [Required][MaxLength(100)]string Name,
    [MaxLength(255)]string? Description = null
);
