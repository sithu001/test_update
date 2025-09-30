using System;
using System.Collections.Generic;

namespace MOCDEMSNEW.Models;

public partial class RepRemarkType
{
    public int RremarkId { get; set; }

    public string? RremarkRemark { get; set; }

    public short? RremarkType { get; set; }

    public int? RremarkCategory { get; set; }

    public int? RremarkPos { get; set; }

    public int? RremarkSortOrder { get; set; }
}
