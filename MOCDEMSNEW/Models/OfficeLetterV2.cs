using System;
using System.Collections.Generic;

namespace MOCDEMSNEW.Models;

public partial class OfficeLetterV2
{
    public int OlId { get; set; }

    public int? OlType { get; set; }

    public int? OlParent { get; set; }

    public string? OlSubject { get; set; }

    public string? OlMention { get; set; }

    public string? OlBody { get; set; }

    public string? OlSignature { get; set; }

    public int? OlSender { get; set; }

    public int? OlSenderRank { get; set; }

    public int? OlSendSection { get; set; }

    public int? OlSendDepartment { get; set; }

    public int? OlShare { get; set; }

    public string? OlNo { get; set; }

    public DateTime? OlDate { get; set; }

    public string? OlCopy { get; set; }

    public int? OlIsCopy { get; set; }

    public string? OlCopyText { get; set; }

    public int? OlIsDist { get; set; }

    public int? OlSentDone { get; set; }

    public int? OlBehalf { get; set; }

    public int? OlOwner { get; set; }

    public string? OlOwnerName { get; set; }

    public int? OlOwnerRank { get; set; }

    public int? OlIsPdf { get; set; }

    public DateTime? OlCreateDate { get; set; }

    public string? OlAttach { get; set; }

    public string? OlDepartmentName { get; set; }

    public int? OlSecurity { get; set; }

    public string? OlPageNo { get; set; }

    public int? OlIsSign { get; set; }

    public int? OlIsSignDone { get; set; }

    public int? OlIsSend { get; set; }
}
