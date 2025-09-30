using System;
using System.Collections.Generic;

namespace MOCDEMSNEW.Models;

public partial class Position
{
    public int PosId { get; set; }

    public string? PosName { get; set; }

    public int? PosPossibleRank1 { get; set; }

    public int? PosPossibleRank2 { get; set; }

    public int? PosSortOrder { get; set; }

    public string? PosSname { get; set; }
}
