using System;
using System.Collections.Generic;

namespace MOCDEMSNEW.Models;

public partial class Olread
{
    public int OlrId { get; set; }

    public int? OlrOl { get; set; }

    public int? OlrUser { get; set; }

    public int? OlrType { get; set; }

    public DateTime? OlrCreateDate { get; set; }
}
