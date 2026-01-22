using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class ViewSetting
{
    public Guid Id { get; set; }

    public Guid ViewId { get; set; }

    public string SettingKey { get; set; } = null!;

    public string? SettingValue { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual View View { get; set; } = null!;
}
