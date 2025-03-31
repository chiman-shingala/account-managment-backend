using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class KtMast
{
    public DateTime? Date { get; set; }

    public string Kt { get; set; } = null!;

    public decimal? GoldPrice { get; set; }

    public decimal? Per { get; set; }
}
