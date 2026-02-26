using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using workmonitorAPI.Data;
using workmonitorAPI.DTOs.SearcherDTOs;
using workmonitorAPI.Services.Interfaces;

namespace workmonitorAPI.Services;

public class SearcherService : ISearcherService
{
  private readonly AppDbContext _db;

  public SearcherService(AppDbContext db)
  {
    _db = db;
  }

  public async Task<SearcherResultDto> SearchAsync(SearcherQueryDto queryDto)
  {
    if (string.IsNullOrWhiteSpace(queryDto.Query))
    {
      return new SearcherResultDto(
          Array.Empty<SearcherWorkspaceResultDto>(),
          Array.Empty<SearcherBoardResultDto>(),
          Array.Empty<SearcherGroupResultDto>(),
          Array.Empty<SearcherItemResultDto>()
      );
    }

    var normalizedQuery = queryDto.Query.ToLower().Replace(" ", string.Empty);

    var groupMatches = await _db.Groups
        .AsNoTracking()
        .Where(g =>
            g.DeletedAt == null &&
            g.Board.DeletedAt == null &&
            g.Board.Workspace.DeletedAt == null &&
            EF.Functions.Like(
                (g.Name ?? string.Empty).ToLower().Replace(" ", string.Empty),
                $"%{normalizedQuery}%"
            )
        )
        .Select(g => new
        {
          WorkspaceId = g.Board.WorkspaceId,
          WorkspaceName = g.Board.Workspace.Name,
          BoardId = g.BoardId,
          BoardName = g.Board.Name,
          GroupId = g.Id,
          GroupName = g.Name
        })
        .ToListAsync();

    var itemMatches = await _db.Items
        .AsNoTracking()
        .Where(i =>
            i.DeletedAt == null &&
            i.Group.DeletedAt == null &&
            i.Group.Board.DeletedAt == null &&
            i.Group.Board.Workspace.DeletedAt == null &&
            (
                EF.Functions.Like(
                    (i.Name ?? string.Empty).ToLower().Replace(" ", string.Empty),
                    $"%{normalizedQuery}%"
                ) ||
                EF.Functions.Like(
                    (i.Project != null ? i.Project.NomProyecto : string.Empty)!.ToLower().Replace(" ", string.Empty),
                    $"%{normalizedQuery}%"
                )
            )
        )
        .Select(i => new
        {
          WorkspaceId = i.Group.Board.WorkspaceId,
          WorkspaceName = i.Group.Board.Workspace.Name,
          BoardId = i.Group.BoardId,
          BoardName = i.Group.Board.Name,
          GroupId = i.GroupId,
          GroupName = i.Group.Name,
          ItemId = i.Id,
          ItemName = i.Name
        })
        .ToListAsync();

    var workspaceMatches = groupMatches
        .Select(g => new { g.WorkspaceId, g.WorkspaceName })
        .Concat(itemMatches.Select(i => new { i.WorkspaceId, i.WorkspaceName }))
        .GroupBy(x => new { x.WorkspaceId, x.WorkspaceName })
        .Select(g => new SearcherWorkspaceResultDto(g.Key.WorkspaceId, g.Key.WorkspaceName))
        .OrderBy(x => x.Name)
        .ToList();

    var boardMatches = groupMatches
        .Select(g => new { g.BoardId, g.WorkspaceId, g.BoardName })
        .Concat(itemMatches.Select(i => new { i.BoardId, i.WorkspaceId, i.BoardName }))
        .GroupBy(x => new { x.BoardId, x.WorkspaceId, x.BoardName })
        .Select(g => new SearcherBoardResultDto(g.Key.BoardId, g.Key.WorkspaceId, g.Key.BoardName))
        .OrderBy(x => x.Name)
        .ToList();

    var groupResultMatches = groupMatches
        .Select(g => new { g.GroupId, g.BoardId, g.GroupName })
        .Concat(itemMatches.Select(i => new { i.GroupId, i.BoardId, i.GroupName }))
        .GroupBy(x => new { x.GroupId, x.BoardId, x.GroupName })
        .Select(g => new SearcherGroupResultDto(g.Key.GroupId, g.Key.BoardId, g.Key.GroupName))
        .OrderBy(x => x.Name)
        .ToList();

    var itemResultMatches = itemMatches
        .GroupBy(i => new { i.ItemId, i.GroupId, i.ItemName })
        .Select(g => new SearcherItemResultDto(g.Key.ItemId, g.Key.GroupId, g.Key.ItemName))
        .OrderBy(x => x.Name)
        .ToList();

    return new SearcherResultDto(workspaceMatches, boardMatches, groupResultMatches, itemResultMatches);
  }
}
