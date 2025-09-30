using System;
using System.Collections.Generic;

namespace MOCDEMSNEW.Models;

public partial class RepRemarkCategory
{
    public int RrcId { get; set; }

    public string? RrcTitle { get; set; }

    public int? RrcSortOrder { get; set; }

    public DateTime? RrcCreateDate { get; set; }
}
