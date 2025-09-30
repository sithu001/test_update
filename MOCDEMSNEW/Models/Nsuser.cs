using System;
using System.Collections.Generic;

namespace MOCDEMSNEW.Models;

public partial class Nsuser
{
    public int NsuserId { get; set; }

    public int? NsuserNoteSheet { get; set; }

    public int? NsuserUser { get; set; }

    public int? NsuserCreateUser { get; set; }
}
