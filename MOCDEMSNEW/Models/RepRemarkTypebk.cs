using System;
using System.Collections.Generic;

namespace MOCDEMSNEW.Models;

public partial class RepRemarkTypebk
{
    public int RremarkId { get; set; }

    public string? RremarkRemark { get; set; }

    public int? RremarkType { get; set; }

    public int? RremarkPos { get; set; }

    public int? RremarkSortOrder { get; set; }

    public int? RremarkCategory { get; set; }
}
