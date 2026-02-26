using System;

namespace workmonitorAPI.DTOs.SearcherDTOs;

public record SearcherItemResultDto(Guid Id, Guid GroupId, string Name);
