using System;
using System.Collections.Generic;

namespace MOCDEMSNEW.Models;

public partial class Venue
{
    public int VId { get; set; }

    public string VName { get; set; } = null!;

    public int VSortOrder { get; set; }
}
