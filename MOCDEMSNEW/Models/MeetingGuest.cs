using System;
using System.Collections.Generic;

namespace MOCDEMSNEW.Models;

public partial class MeetingGuest
{
    public int MgId { get; set; }

    public int? MgMrid { get; set; }

    public int? MgPosition { get; set; }

    public int? MgDep { get; set; }

    public int? MgSec { get; set; }

    public bool? MgIsExternal { get; set; }

    public string? MgExternalGuest { get; set; }
}
