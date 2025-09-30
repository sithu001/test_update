using System;
using System.Collections.Generic;

namespace MOCDEMSNEW.Models;

public partial class Mail
{
    public int MId { get; set; }

    public int? MTo { get; set; }

    public string? MToName { get; set; }

    public string? MCcname { get; set; }

    public int? MFrom { get; set; }

    public string? MFromName { get; set; }

    public string? MSubject { get; set; }

    public string? MMsgType { get; set; }

    public DateTime? MSent { get; set; }

    public DateTime? MReceived { get; set; }

    public string? MAttachments { get; set; }

    public string? MSfileName { get; set; }

    public bool? MIsHtml { get; set; }

    public int? MFolder { get; set; }

    public bool? MIsSent { get; set; }

    public bool? MIsRead { get; set; }

    public int? MRefId { get; set; }

    public bool? MIsNotify { get; set; }

    public int? MOmailId { get; set; }

    public int? MUniqueId { get; set; }

    public bool? MIsDeleted { get; set; }

    public bool? MIsDraft { get; set; }

    public string? MEmployees { get; set; }

    public int? MOwner { get; set; }

    public bool? MIsPrivate { get; set; }

    public string? MContacts { get; set; }

    public string? MCategories { get; set; }

    public string? MMessage { get; set; }

    public string? MBccname { get; set; }
}
