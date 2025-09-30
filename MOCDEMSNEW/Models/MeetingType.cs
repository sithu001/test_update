using System;
using System.Collections.Generic;

namespace MOCDEMSNEW.Models;

public partial class MeetingType
{
    public int MtId { get; set; }

    public string? MtName { get; set; }

    public int? MtSortOrder { get; set; }
}
