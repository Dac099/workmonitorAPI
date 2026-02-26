using System;

namespace workmonitorAPI.DTOs.GanttDTOs;

public record GanttItemDto(
    Guid Id,
    Guid GroupId,
    string Name,
    int Position,
    Guid? TimelineValueId,
    string? TimelineValue
);
