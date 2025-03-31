using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class LustMast
{
    public short LuCode { get; set; }

    public string? LuName { get; set; }

    public decimal? Per { get; set; }

    public string? SortName { get; set; }

    public short? Ord { get; set; }
}
