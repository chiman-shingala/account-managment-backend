using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class TbincMast
{
    public short TbinCode { get; set; }

    public string? TbinName { get; set; }

    public decimal? Per { get; set; }

    public string? SortName { get; set; }

    public short? Ord { get; set; }
}
