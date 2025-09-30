using System;
using System.Collections.Generic;

namespace MOCDEMSNEW.Models;

public partial class Olshare
{
    public int OlsId { get; set; }

    public int? OlsOl { get; set; }

    public string? OlsToList { get; set; }

    public int? OlsTo { get; set; }

    public DateTime? OlsCreateDate { get; set; }
}
