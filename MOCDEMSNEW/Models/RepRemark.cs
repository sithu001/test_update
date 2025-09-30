using System;
using System.Collections.Generic;

namespace MOCDEMSNEW.Models;

public partial class RepRemark
{
    public int RrId { get; set; }

    public string? RrRemark { get; set; }

    public int? RrUser { get; set; }

    public int? RrReport { get; set; }

    public DateTime? RrCreateDate { get; set; }
}
