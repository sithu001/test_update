using System;
using System.Collections.Generic;

namespace MOCDEMSNEW.Models;

public partial class RepCat
{
    public int RcId { get; set; }

    public string? RcName { get; set; }

    public int? RcDepartment { get; set; }

    public int? RcSection { get; set; }

    public bool? RcIsArchive { get; set; }

    public bool? RcIsSecret { get; set; }
}
