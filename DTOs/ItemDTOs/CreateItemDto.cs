using System.ComponentModel.DataAnnotations;

namespace workmonitorAPI.DTOs.ItemDTOs;

public record CreateItemDto(
    [Required] Guid GroupId,
    [Required][MaxLength(100)] string Name,
    string? ProjectId = null
);
