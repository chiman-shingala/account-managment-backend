using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class VuJewStockIssView
{
    public string? Pid { get; set; }

    public decimal? Carat { get; set; }

    public decimal? Rate { get; set; }

    public decimal? Amount { get; set; }

    public string? Oper { get; set; }

    public string? PCode { get; set; }

    public string CompCode { get; set; } = null!;

    public int Acyear { get; set; }

    public DateTime? Idate { get; set; }
}
