using System;
using System.Collections.Generic;

namespace MOCDEMSNEW.Models;

public partial class Log
{
    public int LogId { get; set; }

    public int? LogUser { get; set; }

    public string? LogUserName { get; set; }

    public int? LogItem { get; set; }

    public string? LogItemName { get; set; }

    public int? LogService { get; set; }

    public int? LogAction { get; set; }

    public string? LogIpaddr { get; set; }

    public DateTime? LogDate { get; set; }

    public DateTime? LogTime { get; set; }

    public string? LogRefer { get; set; }

    public string? LogUrl { get; set; }

    public string? LogTemplate { get; set; }

    public string? LogDescription { get; set; }
}
