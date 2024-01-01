using System;
using System.Collections.Generic;

namespace EPMS.API.Models;

public partial class Employee
{
    public string EmployeeId { get; set; } = null!;

    public string? EmployeeName { get; set; }

    public string? DepartmentId { get; set; }

    public virtual Department? Department { get; set; }

    public virtual ICollection<AssignProject> AssignProjects { get; set; } = new List<AssignProject>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
