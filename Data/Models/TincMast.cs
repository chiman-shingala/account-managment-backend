using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class TincMast
{
    public short TinCode { get; set; }

    public string? TinName { get; set; }

    public decimal? Per { get; set; }

    public string? SortName { get; set; }

    public short? Ord { get; set; }
}
