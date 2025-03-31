using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class MenuMast
{
    public int MId { get; set; }

    public int? FormId { get; set; }

    public string? MName { get; set; }

    public string? BName { get; set; }
}
