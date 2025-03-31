using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class CurrMast
{
    public string CnCy { get; set; } = null!;

    public decimal? Conv { get; set; }

    public int? Ord { get; set; }

    public string? PcnCy { get; set; }
}
