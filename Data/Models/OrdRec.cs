using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class OrdRec
{
    public int TrnNo { get; set; }

    public int SrNo { get; set; }

    public string CompCode { get; set; } = null!;

    public int AcYear { get; set; }

    public DateTime? Rdate { get; set; }

    public string? PCode { get; set; }

    public string? ICode { get; set; }

    public decimal? Qty { get; set; }

    public decimal? Weight { get; set; }

    public string? Remark { get; set; }

    public int? ItrnNo { get; set; }

    public DateTime? Idate { get; set; }

    public string? IinvNo { get; set; }

    public string? Luser { get; set; }

    public DateTime? TrnTime { get; set; }

    public string? JewId { get; set; }

    public string? DCode { get; set; }

    public string? Kt { get; set; }

    public decimal? KtConvRate { get; set; }

    public decimal? RecWeight { get; set; }

    public decimal? FinalAftConv { get; set; }

    public string? Description { get; set; }

    public decimal? LabourRate { get; set; }

    public decimal? LabourAmount { get; set; }

    public int? TotalUsedPcs { get; set; }

    public decimal? TotalUsedCarat { get; set; }
}
