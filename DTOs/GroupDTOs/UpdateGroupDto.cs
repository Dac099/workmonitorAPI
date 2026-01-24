using System.ComponentModel.DataAnnotations;

namespace workmonitorAPI.DTOs.GroupDTOs;

public record UpdateGroupDto(
    [MaxLength(100)] string? Name,
    int? Position,
    [MaxLength(7)] string? Color
);
