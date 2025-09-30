using System;
using System.Collections.Generic;

namespace MOCDEMSNEW.Models;

public partial class OfficeLetterRemark
{
    public int OlrId { get; set; }

    public int? OlrPosition { get; set; }

    public string? OlrRemarks { get; set; }

    public int? OlrSortOrder { get; set; }
}
