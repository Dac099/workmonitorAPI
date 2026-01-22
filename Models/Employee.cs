using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class Employee
{
    public Guid Id { get; set; }

    public string? UserId { get; set; }

    public string? Name { get; set; }

    public string? PaternalSurname { get; set; }

    public string? MaternalSurname { get; set; }

    public string? Rfc { get; set; }

    public string? Curp { get; set; }

    public string? Department { get; set; }

    public string? Position { get; set; }

    public string? Imss { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? BirthDate { get; set; }

    public virtual ICollection<UserAsignedToItem> UserAsignedToItems { get; set; } = new List<UserAsignedToItem>();
}
