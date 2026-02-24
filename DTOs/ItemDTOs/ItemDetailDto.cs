using System;
using System.Collections.Generic;
using workmonitorAPI.DTOs.ChatDTOs;
using workmonitorAPI.DTOs.ProyectDTOs;
using workmonitorAPI.DTOs.SubItemDTOs;

namespace workmonitorAPI.DTOs.ItemDTOs;

public record ItemDetailDto(
    Guid Id,
    Guid GroupId,
    string Name,
    int Position,
    string? ProjectId,
    ProjectDetailDto? Project,
    IEnumerable<SubItemDto> SubItems,
    IEnumerable<ChatDto> Chats
);
