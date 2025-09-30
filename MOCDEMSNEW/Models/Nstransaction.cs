using System;
using System.Collections.Generic;

namespace MOCDEMSNEW.Models;

public partial class Nstransaction
{
    public int NstId { get; set; }

    public int? NstNoteSheet { get; set; }

    public DateTime? NstDate { get; set; }

    public int? NstFuser { get; set; }

    public int? NstTuser { get; set; }

    public int? NstInOut { get; set; }

    public string? NstRemark { get; set; }

    public bool? NstIsFirst { get; set; }

    public int? NstCreateUser { get; set; }

    public DateTime? NstCreateDate { get; set; }

    public string? NstAttach { get; set; }

    public bool? NstIsPending { get; set; }
}
