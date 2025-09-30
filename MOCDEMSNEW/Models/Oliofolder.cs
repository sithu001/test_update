using System;
using System.Collections.Generic;

namespace MOCDEMSNEW.Models;

public partial class Oliofolder
{
    public int OlfId { get; set; }

    public string? OlfName { get; set; }

    public int? OlfUser { get; set; }

    public int? OlfSortOrder { get; set; }

    public int? OlfInout { get; set; }

    public DateTime? OlfCreateDate { get; set; }
}
