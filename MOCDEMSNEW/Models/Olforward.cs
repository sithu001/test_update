using System;
using System.Collections.Generic;

namespace MOCDEMSNEW.Models;

public partial class Olforward
{
    public int OlfId { get; set; }

    public int? OlfOl { get; set; }

    public int? OlfFrom { get; set; }

    public int? OlfTo { get; set; }

    public string? OlfTolist { get; set; }

    public string? OlfMessage { get; set; }

    public DateTime? OlfCreatedate { get; set; }
}
