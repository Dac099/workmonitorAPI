using System;

namespace workmonitorAPI.DTOs.GanttDTOs;

public record GanttGroupDto(
    Guid Id,
    Guid BoardId,
    string Name,
    int Position,
    string? Color
);
