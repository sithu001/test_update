using System;
using System.Collections.Generic;

namespace MOCDEMSNEW.Models;

public partial class OfficeLetter
{
    public int OlId { get; set; }

    public int? OlCat { get; set; }

    public string? OlRefNo { get; set; }

    public string? OlFrom { get; set; }

    public DateTime? OlDate { get; set; }

    public string? OlMessage { get; set; }

    public string? OlPlace { get; set; }

    public string? OlAttach { get; set; }

    public int? OlLevel { get; set; }

    public string? OlHeader { get; set; }

    public int? OlType { get; set; }

    public bool? OlInOut { get; set; }

    public int? OlCreateUser { get; set; }

    public DateTime? OlCreateDate { get; set; }

    public string? OlSubject { get; set; }
}
