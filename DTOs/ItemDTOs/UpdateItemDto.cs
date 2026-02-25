using System.ComponentModel.DataAnnotations;

namespace workmonitorAPI.DTOs.ItemDTOs;

public record UpdateItemDto(
    [MaxLength(100)] string? Name,
    int? Position,
    string? ProjectId
);
