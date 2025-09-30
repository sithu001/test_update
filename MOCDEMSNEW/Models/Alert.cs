using System;
using System.Collections.Generic;

namespace MOCDEMSNEW.Models;

public partial class Alert
{
    public int AId { get; set; }

    public string? ANote { get; set; }

    public DateTime? ADateTime { get; set; }

    public bool? AAlerted { get; set; }

    public int? ASender { get; set; }

    public int? AOwner { get; set; }

    public int? AItem { get; set; }

    public int? AItemId { get; set; }
}
