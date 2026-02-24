using System;
using System.ComponentModel.DataAnnotations;

namespace workmonitorAPI.DTOs.ChatDTOs;

public record CreateChatDto(
    [Required] Guid ItemId,
    [Required][MaxLength(1000)] string Message,
    [MaxLength(1000)] string? Responses = null,
    [MaxLength(1000)] string? Tasks = null
);
