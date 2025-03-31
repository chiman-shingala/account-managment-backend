using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class SbillRetH
{
    public decimal TrnNo { get; set; }

    public int AcYear { get; set; }

    public string CompCode { get; set; } = null!;

    public string? Oper { get; set; }

    public string? InvNo { get; set; }

    public DateTime? TrnDate { get; set; }

    public string? PCode { get; set; }

    public decimal? Conv { get; set; }

    public string? CnCy { get; set; }

    public decimal? SCarat { get; set; }

    public decimal? Amount { get; set; }

    public decimal? Bramount { get; set; }

    public decimal? NetAmt { get; set; }

    public decimal? PayAmt { get; set; }

    public string? OutOk { get; set; }

    public int? DueDay { get; set; }

    public DateTime? DueDate { get; set; }

    public string? Remark { get; set; }

    public string? PrCode { get; set; }

    public string? Stype { get; set; }

    public decimal? CertAmt { get; set; }

    public decimal? NcertAmt { get; set; }

    public string? Otype { get; set; }

    public decimal? Pdis { get; set; }

    public decimal? AmtDiff { get; set; }

    public string? Luser { get; set; }

    public DateTime? TrnTime { get; set; }
}
