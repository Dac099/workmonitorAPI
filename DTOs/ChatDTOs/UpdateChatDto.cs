using System.ComponentModel.DataAnnotations;

namespace workmonitorAPI.DTOs.ChatDTOs;

public record UpdateChatDto(
    [MaxLength(1000)] string? Message = null,
    [MaxLength(1000)] string? Responses = null,
    [MaxLength(1000)] string? Tasks = null
);
