using System;

namespace workmonitorAPI.DTOs.SearcherDTOs;

public record SearcherBoardResultDto(Guid Id, Guid WorkspaceId, string Name);
