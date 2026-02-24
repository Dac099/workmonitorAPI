namespace workmonitorAPI.DTOs.ChatDTOs;

public record ChatDto(
    Guid Id,
    Guid? ItemId,
    string? Message,
    string? CreatedBy,
    string? Responses,
    string? Tasks,
    string? CreatedAt
);
