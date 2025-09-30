using System;
using System.Collections.Generic;

namespace MOCDEMSNEW.Models;

public partial class NsshareUser
{
    public int NssuserId { get; set; }

    public int? NssuserNoteSheet { get; set; }

    public int? NssuserUser { get; set; }

    public DateTime? NssuserDate { get; set; }
}
