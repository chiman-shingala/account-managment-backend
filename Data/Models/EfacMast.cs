using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class EfacMast
{
    public short EfCode { get; set; }

    public string? EfName { get; set; }

    public decimal? Per { get; set; }

    public string? SortName { get; set; }

    public short? Ord { get; set; }
}
