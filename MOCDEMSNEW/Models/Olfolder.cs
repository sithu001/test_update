using System;
using System.Collections.Generic;

namespace MOCDEMSNEW.Models;

public partial class Olfolder
{
    public int OlfId { get; set; }

    public string? OlfName { get; set; }

    public int? OlfOwner { get; set; }

    public DateTime? OlfCreateDate { get; set; }
}
