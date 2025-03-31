using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class SoincMast
{
    public short SoinCode { get; set; }

    public string? SoinName { get; set; }

    public decimal? Per { get; set; }

    public string? SortName { get; set; }

    public short? Ord { get; set; }
}
