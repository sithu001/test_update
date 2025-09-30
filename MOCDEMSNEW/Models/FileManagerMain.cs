using System;
using System.Collections.Generic;

namespace MOCDEMSNEW.Models;

public partial class FileManagerMain
{
    public int FmnId { get; set; }

    public int? FmnDepartment { get; set; }

    public int? FmnSection { get; set; }

    public string? FmnTitle { get; set; }

    public int? FmnSortOrder { get; set; }

    public int? FmnPosition { get; set; }

    public int? FmnParent { get; set; }

    public int? FmnSubSection { get; set; }
}
