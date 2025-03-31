using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class VuGoldView
{
    public int Ord { get; set; }

    public DateTime? TrnTime { get; set; }

    public string TrnType { get; set; } = null!;

    public int Acyear { get; set; }

    public string CompCode { get; set; } = null!;

    public string? Pid { get; set; }

    public decimal? Weight { get; set; }

    public string? CnCy { get; set; }

    public decimal? Conv { get; set; }

    public decimal? Rate { get; set; }

    public decimal? Amount { get; set; }

    public DateTime? TrnDate { get; set; }

    public string StkOper { get; set; } = null!;
}
