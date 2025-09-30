using System;
using System.Collections.Generic;

namespace MOCDEMSNEW.Models;

public partial class Olreg
{
    public int OlrId { get; set; }

    public int? OlrCat { get; set; }

    public string? OlrRefNo { get; set; }

    public int? OlrFrom { get; set; }

    public int? OlrTo { get; set; }

    public DateTime? OlrDate { get; set; }

    public string? OlrSubject { get; set; }

    public string? OlrMessage { get; set; }

    public string? OlrPlace { get; set; }

    public string? OlrAttach { get; set; }

    public int? OlrLevel { get; set; }

    public string? OlrHeader { get; set; }

    public int? OlrType { get; set; }

    public bool? OlrInOut { get; set; }

    public int? OlrCreateUser { get; set; }

    public DateTime? OlrCreateDate { get; set; }

    public int? OlrRefId { get; set; }

    public bool? OlrIsArchive { get; set; }

    public int? OlrUniqueId { get; set; }

    public bool? OlrIsFolder { get; set; }

    public bool? OlrIsSend { get; set; }

    public int? OlrCcid { get; set; }

    public bool? OlrIsRead { get; set; }
}
