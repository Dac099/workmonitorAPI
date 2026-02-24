using System;

namespace workmonitorAPI.DTOs.ProyectDTOs;

public record ProjectDetailDto(
    string ProjectId,
    string? ProjectName,
    string? ProjectDescription,
    DateOnly? StartDate,
    DateOnly? EndDate,
    int? ClientId,
    string? ClientName
);
