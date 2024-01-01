using System;
using System.Collections.Generic;

namespace EPMS.API.Models;

public partial class User
{
    public Guid UserId { get; set; }

    public string Name { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Role { get; set; } = null!;

    public string? EmployeeId { get; set; }

    public virtual Employee? Employee { get; set; }
}
