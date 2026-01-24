using System.ComponentModel.DataAnnotations;

namespace workmonitorAPI.DTOs.GroupDTOs;

public record CreateGroupDto(
    [Required] Guid BoardId,
    [Required][MaxLength(100)] string Name,
    [MaxLength(7)] string? Color = null
);
