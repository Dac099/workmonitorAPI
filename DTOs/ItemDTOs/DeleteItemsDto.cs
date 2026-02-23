using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace workmonitorAPI.DTOs.ItemDTOs;

public record DeleteItemsDto(
    [Required] IEnumerable<Guid> ItemIds
);
