using System;
using System.Collections.Generic;

namespace workmonitorAPI.DTOs.BoardDTOs;

public record ExportBoardDto(
    List<Guid> GroupIds,
    List<Guid> ColumnIds,
    bool IncludeGantt
);
