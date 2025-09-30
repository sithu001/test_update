using System;
using System.Collections.Generic;

namespace MOCDEMSNEW.Models;

public partial class MeetingAnnouncer
{
    public int MaId { get; set; }

    public int MaMrid { get; set; }

    public int MaEmpId { get; set; }

    public int MaPosition { get; set; }

    public int MaDep { get; set; }

    public int? MaSec { get; set; }
}
