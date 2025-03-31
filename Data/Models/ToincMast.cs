using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class ToincMast
{
    public short ToinCode { get; set; }

    public string? ToinName { get; set; }

    public decimal? Per { get; set; }

    public string? SortName { get; set; }

    public short? Ord { get; set; }
}
