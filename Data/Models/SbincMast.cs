using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class SbincMast
{
    public short SbinCode { get; set; }

    public string? SbinName { get; set; }

    public decimal? Per { get; set; }

    public string? SortName { get; set; }

    public short? Ord { get; set; }
}
