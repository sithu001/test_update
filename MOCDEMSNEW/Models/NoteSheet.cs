using System;
using System.Collections.Generic;

namespace MOCDEMSNEW.Models;

public partial class NoteSheet
{
    public int NsId { get; set; }

    public string? NsTitle { get; set; }

    public string? NsDesc { get; set; }

    public DateTime? NsDate { get; set; }

    public int? NsCreateUser { get; set; }

    public DateTime? NsCreateDate { get; set; }

    public bool? NsIsFinish { get; set; }

    public int? NsUniqueId { get; set; }

    public string? NsAttachFile { get; set; }

    public string? NsReference { get; set; }

    public string? NsFormNo { get; set; }

    public string? NsPlace { get; set; }

    public string? NsHeader { get; set; }

    public int? NsFolder { get; set; }

    public bool? NsIsdraft { get; set; }
}
