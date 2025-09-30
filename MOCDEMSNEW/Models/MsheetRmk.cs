using System;
using System.Collections.Generic;

namespace MOCDEMSNEW.Models;

public partial class MsheetRmk
{
    public int MsrId { get; set; }

    public int? MsrMs { get; set; }

    public int? MsrFrom { get; set; }

    public int? MsrFromPosition { get; set; }

    public string? MsrFromSign { get; set; }

    public int? MsrTo { get; set; }

    public int? MsrToPosition { get; set; }

    public string? MsrRemarks { get; set; }

    public DateTime? MsrDate { get; set; }

    public int? MsrStarter { get; set; }

    public int? MsrIsCompleted { get; set; }

    public DateTime? MsrCreateDate { get; set; }
}
