using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class BrnMast
{
    public short BrnCode { get; set; }

    public string? BrnName { get; set; }

    public decimal? Per { get; set; }

    public string? SortName { get; set; }

    public short? Ord { get; set; }
}
