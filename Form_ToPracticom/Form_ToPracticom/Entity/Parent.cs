using System;
using System.Collections.Generic;

namespace Repositories.Entity;

public partial class Parent
{
    public int Id { get; set; }

    public string? IdNumberParent { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? MaleOrFemale { get; set; }

    public string? Hmo { get; set; }

    public virtual ICollection<Child> Children { get; } = new List<Child>();
}
