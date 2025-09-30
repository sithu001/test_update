using System;
using System.Collections.Generic;

namespace MOCDEMSNEW.Models;

public partial class SubSection
{
    public int SsId { get; set; }

    public int? SsDepartment { get; set; }

    public int? SsSection { get; set; }

    public string? SsTitle { get; set; }

    public int? SsSortOrder { get; set; }
}
