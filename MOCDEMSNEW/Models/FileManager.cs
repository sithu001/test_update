using System;
using System.Collections.Generic;

namespace MOCDEMSNEW.Models;

public partial class FileManager
{
    public int FmId { get; set; }

    public int? FmType { get; set; }

    public int? FmMinuteSheet { get; set; }

    public int? FmSection { get; set; }

    public int? FmOlType { get; set; }

    public DateTime? FmCreateDate { get; set; }

    public int? FmFm { get; set; }

    public int? FmCreateUser { get; set; }

    public int? FmFmSub { get; set; }
}
