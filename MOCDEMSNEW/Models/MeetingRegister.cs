using System;
using System.Collections.Generic;

namespace MOCDEMSNEW.Models;

public partial class MeetingRegister
{
    public int MId { get; set; }

    public int? MOrganizedDep { get; set; }

    public int? MOrganizedSec { get; set; }

    public string? MDescription { get; set; }

    public string? MPlace { get; set; }

    public DateTime? MDate { get; set; }

    public string? MInviationLetter { get; set; }

    public string? MRemark { get; set; }

    public DateTime? MRegisteredDate { get; set; }

    public DateTime? MEditDate { get; set; }

    public int? MFrom { get; set; }

    public int? MTo { get; set; }

    public bool? MIsConfirm { get; set; }

    public int? MType { get; set; }
}
