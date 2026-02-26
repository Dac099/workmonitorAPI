using System;
using System.Collections.Generic;

namespace workmonitorAPI.DTOs.GanttDTOs;

public record GanttBoardDto(
    Guid BoardId,
    Guid? TimelineColumnId,
    string? TimelineColumnName,
    IEnumerable<GanttGroupDto> Groups,
    IEnumerable<GanttItemDto> Items
);
