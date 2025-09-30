using System;
using System.Collections.Generic;

namespace MOCDEMSNEW.Models;

public partial class EmployeeTwoFactor
{
    public int Id { get; set; }

    public int EmployeeId { get; set; }

    public string? SecretKey { get; set; }

    public string? RecoveryCodes { get; set; }

    public bool IsEnabled { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual Employee Employee { get; set; } = null!;
}
