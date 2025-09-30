using System;
using System.Collections.Generic;

namespace MOCDEMSNEW.Models;

public partial class Olcat
{
    public int OlcId { get; set; }

    public string? OlcName { get; set; }

    public int? OlcSection { get; set; }

    public int? OlcSortOrder { get; set; }
}
