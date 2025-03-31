using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class CulMast
{
    public short CuCode { get; set; }

    public string? CuName { get; set; }

    public decimal? Per { get; set; }

    public string? SortName { get; set; }

    public short? Ord { get; set; }
}
