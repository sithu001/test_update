using System;
using System.Collections.Generic;

namespace MOCDEMSNEW.Models;

public partial class Nsfolder
{
    public int NsfId { get; set; }

    public string? NsfName { get; set; }

    public int? NsfUser { get; set; }

    public int? NsfSortOrder { get; set; }

    public DateTime? NsfCreateDate { get; set; }
}
