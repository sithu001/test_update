using System;
using System.Collections.Generic;

namespace MOCDEMSNEW.Models;

public partial class RepTran
{
    public int RtId { get; set; }

    public int? RtReport { get; set; }

    public int? RtLevel { get; set; }

    public string? RtFile { get; set; }

    public DateTime? RtDate { get; set; }

    public int? RtCreateUser { get; set; }

    public string? RtRemark { get; set; }
}
