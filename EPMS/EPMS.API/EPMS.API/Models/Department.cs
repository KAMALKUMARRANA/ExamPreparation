using System;
using System.Collections.Generic;

namespace EPMS.API.Models;

public partial class Department
{
    public string DepartmentId { get; set; } = null!;

    public string? Name { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
