using System;
using System.Collections.Generic;

namespace MOCDEMSNEW.Models;

public partial class RepOldVersion16Feb13
{
    public int RepId { get; set; }

    public int? RepCat { get; set; }

    public string? RepSubject { get; set; }

    public string? RepMessage { get; set; }

    public string? RepAttach { get; set; }

    public int? RepLevel { get; set; }

    public int? RepCreateUser { get; set; }

    public DateTime? RepDate { get; set; }

    public string? RepPlace { get; set; }

    public bool? RepIsPublic { get; set; }

    public int? RepUniqueId { get; set; }

    public string? RepRefNo { get; set; }

    public string? RepHeader { get; set; }

    public bool? RepIsArchive { get; set; }

    public DateTime? RepCreateDate { get; set; }

    public DateTime? RepTddate { get; set; }

    public bool? RepIsturndown { get; set; }
}
