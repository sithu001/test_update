using System;
using System.Collections.Generic;

namespace MOCDEMSNEW.Models;

public partial class Olstep
{
    public int OlsId { get; set; }

    public int? OlsOl { get; set; }

    public int? OlsFrom { get; set; }

    public int? OlsTo { get; set; }

    public string? OlsToList { get; set; }

    public string? OlsRemarks { get; set; }

    public DateTime? OlsCreateDate { get; set; }

    public int? OlsIsCompleted { get; set; }
}
