using System;
using System.Collections.Generic;

namespace MOCDEMSNEW.Models;

public partial class MinuteSheet
{
    public int MsId { get; set; }

    public int? MsParent { get; set; }

    public string? MsUnique { get; set; }

    public DateTime? MsDate { get; set; }

    public string? MsSubject { get; set; }

    public string? MsMention { get; set; }

    public string? MsBody { get; set; }

    public string? MsSign { get; set; }

    public int? MsOwner { get; set; }

    public string? MsSender { get; set; }

    public int? MsSenderRank { get; set; }

    public string? MsRemarks { get; set; }

    public int? MsCurrent { get; set; }

    public int? MsCurrentRank { get; set; }

    public string? MsCurrentRemarks { get; set; }

    public int? MsSentDone { get; set; }

    public DateTime? MsCreateDate { get; set; }

    public string? MsCurrentSign { get; set; }

    public string? MsDepartMent { get; set; }

    public string? MsAttach { get; set; }
}
