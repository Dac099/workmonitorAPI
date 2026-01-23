using System;
using System.ComponentModel.DataAnnotations;

namespace workmonitorAPI.DTOs.BoardDTOs;

public record CreateBoardDto(
    [Required] Guid WorkspaceId,
    [Required][MaxLength(100)] string Name,
    [MaxLength(255)] string? Description = null
);
