using System;
using System.Collections.Generic;

namespace workmonitorAPI.DTOs.TableValueDTOs;

public record StatusValuesByColumnDto(
    Guid ColumnId,
    string ColumnName,
    List<TableValueDto> Values
);
