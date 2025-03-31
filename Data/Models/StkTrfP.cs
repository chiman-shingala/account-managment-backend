using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class StkTrfP
{
    public int TrnNo { get; set; }

    public int SrNo { get; set; }

    public string CompCode { get; set; } = null!;

    public int AcYear { get; set; }

    public string Type { get; set; } = null!;

    public DateTime? TrnDate { get; set; }

    public string? Fpid { get; set; }

    public string? Tpid { get; set; }

    public decimal? Carat { get; set; }

    public decimal? Rate { get; set; }

    public decimal? Conv { get; set; }

    public decimal? Amount { get; set; }

    public string? Remark { get; set; }

    public string? CnCy { get; set; }

    public string? Oper { get; set; }

    public string? Luser { get; set; }

    public DateTime? TrnTime { get; set; }

    public decimal? AvgRate { get; set; }

    public decimal? OrgAvgRate { get; set; }

    public decimal? FpidOrgAvgRate { get; set; }

    public int? PtrnNo { get; set; }

    public int? PsrNo { get; set; }
}
