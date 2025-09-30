using System;
using System.Collections.Generic;

namespace MOCDEMSNEW.Models;

public partial class Favorite
{
    public int FavId { get; set; }

    public string? FavTitle { get; set; }

    public string? FavLink { get; set; }

    public int? FavUser { get; set; }

    public int? FavFolder { get; set; }

    public int? FavCreateUser { get; set; }

    public DateTime? FavCreateDate { get; set; }
}
