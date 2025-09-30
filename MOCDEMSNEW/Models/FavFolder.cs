using System;
using System.Collections.Generic;

namespace MOCDEMSNEW.Models;

public partial class FavFolder
{
    public int FavFId { get; set; }

    public string? FavFName { get; set; }

    public int? FavFUser { get; set; }

    public bool? FavFIsSystem { get; set; }

    public DateTime? FavFCreateDate { get; set; }

    public int? FavFCreateUser { get; set; }
}
