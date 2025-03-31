using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class TrnMastLocal
{
    public string InvType { get; set; } = null!;

    public decimal TrnNo { get; set; }

    public decimal SrNo { get; set; }

    public int AcYear { get; set; }

    public string CompCode { get; set; } = null!;

    public DateTime? TrnDate { get; set; }

    public string? PCode { get; set; }

    public string? PcnCy { get; set; }

    public decimal? Pconv { get; set; }

    public string? AcCode { get; set; }

    public string? AcnCy { get; set; }

    public decimal? Aconv { get; set; }

    public decimal? Conv { get; set; }

    public decimal? Amount { get; set; }

    public decimal? AdjAmt { get; set; }

    public string? Remark { get; set; }

    public bool? IsTransfered { get; set; }

    public short? LtrnNo { get; set; }

    public short? LsrNo { get; set; }

    public DateTime? TrnTime { get; set; }
}
