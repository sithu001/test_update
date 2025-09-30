using System;
using System.Collections.Generic;

namespace MOCDEMSNEW.Models;

public partial class OfficeLRemark
{
    public int OlrId { get; set; }

    public int? OlrOffice { get; set; }

    public int? OlrMaker { get; set; }

    public string? OlrMakerName { get; set; }

    public string? OlrRemark { get; set; }

    public DateTime? OlrCreateDate { get; set; }
}
