using System.Collections.Generic;
using workmonitorAPI.DTOs.ChatDTOs;
using workmonitorAPI.DTOs.TableValueDTOs;

namespace workmonitorAPI.DTOs.GroupDTOs;

public record ItemWithValuesDto(
    Guid Id,
    Guid GroupId,
    string Name,
    int Position,
    string? ProjectId,
    IEnumerable<TableValueWithTypeDto> Values,
    IEnumerable<ChatDto> Chats
);
