using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class PktOpn
{
    public int AcYear { get; set; }

    public string Pid { get; set; } = null!;

    public string CompCode { get; set; } = null!;

    public decimal? Carat { get; set; }

    public decimal? Rate { get; set; }

    public string? CnCy { get; set; }

    public decimal? Conv { get; set; }

    public decimal? Amount { get; set; }

    public string? Oper { get; set; }

    public string? Luser { get; set; }

    public DateTime? TrnDate { get; set; }
}
