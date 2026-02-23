using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace workmonitorAPI.DTOs.ItemDTOs;

public record CopyItemsDto(
    [Required] IEnumerable<Guid> ItemIds,
    [Required] Guid TargetGroupId
);
