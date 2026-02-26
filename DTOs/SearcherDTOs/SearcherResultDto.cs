using System.Collections.Generic;

namespace workmonitorAPI.DTOs.SearcherDTOs;

public record SearcherResultDto(
    IReadOnlyCollection<SearcherWorkspaceResultDto> Workspaces,
    IReadOnlyCollection<SearcherBoardResultDto> Boards,
    IReadOnlyCollection<SearcherGroupResultDto> Groups,
    IReadOnlyCollection<SearcherItemResultDto> Items
);
