using System;
using System.Collections.Generic;

namespace MOCDEMSNEW.Models;

public partial class UserAccount
{
    public int EId { get; set; }

    public string? EFullname { get; set; }

    public string? EName { get; set; }

    public string? EPassword { get; set; }

    public string? ETitle { get; set; }

    public bool? EActive { get; set; }

    public DateTime? ECreateDate { get; set; }

    public DateTime? EEditDate { get; set; }

    public DateTime? EStartDate { get; set; }

    public bool? EGender { get; set; }

    public string? EAddr1 { get; set; }

    public string? EAddr2 { get; set; }

    public string? EAddr3 { get; set; }

    public string? EAddr4 { get; set; }

    public string? EPhone { get; set; }

    public string? EEmail { get; set; }

    public string? ENotes { get; set; }

    public int? ERank { get; set; }

    public int? EDepartment { get; set; }

    public int? ESection { get; set; }

    public int? EProfession { get; set; }

    public int? EPosition { get; set; }

    public int? EHeadRank { get; set; }

    public string? EPhoneExt { get; set; }

    public bool? EIsHead { get; set; }

    public int? ECategories { get; set; }

    public int? ENo { get; set; }

    public int? ELevel { get; set; }

    public string? EMobile { get; set; }

    public int? EDutyCategory { get; set; }

    public int? ERepType { get; set; }
}
