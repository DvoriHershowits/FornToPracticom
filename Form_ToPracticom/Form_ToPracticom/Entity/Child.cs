using System;
using System.Collections.Generic;

namespace Repositories.Entity;

public partial class Child
{
    public int Id { get; set; }

    public string? IdNumberChild { get; set; }

    public string? Name { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public int? IdParent { get; set; }

    public virtual Parent? IdParentNavigation { get; set; }
}
