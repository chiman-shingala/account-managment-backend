using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class JewWsh
{
    public int TrnNo { get; set; }

    public string CompCode { get; set; } = null!;

    public DateTime? TrnDate { get; set; }

    public DateTime? TrnTime { get; set; }

    public string? Wsno { get; set; }

    public string? Fineness { get; set; }

    public string? Stamp { get; set; }

    public string? IssBy { get; set; }

    public DateTime? DelDate { get; set; }

    public string? CnCy { get; set; }

    public decimal? Conv { get; set; }

    public string? Luser { get; set; }

    public decimal? Scarat { get; set; }

    public decimal? Amount { get; set; }

    public decimal? Quan { get; set; }

    public string? Remark { get; set; }
}
