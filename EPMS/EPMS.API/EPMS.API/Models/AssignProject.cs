using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EPMS.API.Models;

public partial class AssignProject
{
    [Key]
    public string AssignId { get; set; }

    public string? EmployeeId { get; set; }

    public string? ProjectId { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual Project? Project { get; set; }
}
