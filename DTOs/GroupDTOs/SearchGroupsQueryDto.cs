using System;

namespace workmonitorAPI.DTOs.GroupDTOs;

public record SearchGroupsQueryDto(
    Guid? BoardId,
    string? GroupName,
    Guid? GroupId
);
