using System;
using System.Collections.Generic;

namespace EPMS.Web.Models;

public partial class Project
{
    public string ProjectId { get; set; } = null!;

    public string? Name { get; set; }

    public virtual ICollection<AssignProject> AssignProjects { get; set; } = new List<AssignProject>();
}
