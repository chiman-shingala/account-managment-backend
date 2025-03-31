using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class RsincMast
{
    public short RsinCode { get; set; }

    public string? RsinName { get; set; }

    public decimal? Per { get; set; }

    public string? SortName { get; set; }

    public short? Ord { get; set; }
}
