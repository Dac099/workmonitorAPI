using System.ComponentModel.DataAnnotations;

namespace workmonitorAPI.DTOs.BoardDTOs;

public record UpdateBoardDto(
    [MaxLength(100)] string? Name,
    [MaxLength(255)] string? Description
);
