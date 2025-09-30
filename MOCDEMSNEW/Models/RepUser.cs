using System;
using System.Collections.Generic;

namespace MOCDEMSNEW.Models;

public partial class RepUser
{
    public int RuId { get; set; }

    public int? RuReport { get; set; }

    public int? RuUser { get; set; }

    public int? RuIsTransaction { get; set; }
}
