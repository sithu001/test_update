using System;
using System.Collections.Generic;

namespace MOCDEMSNEW.Models;

public partial class SysLink
{
    public int SlinkId { get; set; }

    public string? SlinkTitle { get; set; }

    public string? SlinkLink { get; set; }

    public int? SlinkCreateUser { get; set; }

    public DateTime? SlinkCreateDate { get; set; }
}
