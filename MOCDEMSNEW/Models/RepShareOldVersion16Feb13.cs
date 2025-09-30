using System;
using System.Collections.Generic;

namespace MOCDEMSNEW.Models;

public partial class RepShareOldVersion16Feb13
{
    public int RshareId { get; set; }

    public int? RshareRep { get; set; }

    public int? RshareOwner { get; set; }

    public string? RshareUsers { get; set; }

    public int? RshareTo { get; set; }

    public string? RshareRemark { get; set; }

    public DateTime? RshareCreateDate { get; set; }

    public bool? RshareIsRead { get; set; }
}
