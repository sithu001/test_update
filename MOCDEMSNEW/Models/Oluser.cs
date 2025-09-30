using System;
using System.Collections.Generic;

namespace MOCDEMSNEW.Models;

public partial class Oluser
{
    public int OluId { get; set; }

    public int? OluOl { get; set; }

    public int? OluUser { get; set; }

    public int? OluOwner { get; set; }

    public DateTime? OluCreateDate { get; set; }
}
