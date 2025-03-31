using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class OrdIss
{
    public int TrnNo { get; set; }

    public int SrNo { get; set; }

    public string CompCode { get; set; } = null!;

    public int AcYear { get; set; }

    public string Type { get; set; } = null!;

    public DateTime? Idate { get; set; }

    public string? PCode { get; set; }

    public string? ICode { get; set; }

    public string? DCode { get; set; }

    public decimal? Qty { get; set; }

    public decimal? Weight { get; set; }

    public string? Remark { get; set; }

    public string? InvNo { get; set; }

    public string? CnCy { get; set; }

    public decimal? Conv { get; set; }

    public decimal? Carat { get; set; }

    public decimal? Amount { get; set; }

    public string? Luser { get; set; }

    public DateTime? TrnTime { get; set; }

    public string? Tpid { get; set; }
}
