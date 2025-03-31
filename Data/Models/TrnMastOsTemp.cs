using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class TrnMastOsTemp
{
    public string InvType { get; set; } = null!;

    public decimal TrnNo { get; set; }

    public decimal SrNo { get; set; }

    public int AcYear { get; set; }

    public string CompCode { get; set; } = null!;

    public DateTime? TrnDate { get; set; }

    public string? TrnType { get; set; }

    public string? PCode { get; set; }

    public string? PcnCy { get; set; }

    public decimal? Pconv { get; set; }

    public string? AcCode { get; set; }

    public string? AcnCy { get; set; }

    public decimal? Aconv { get; set; }

    public decimal? Conv { get; set; }

    public decimal? Amount { get; set; }

    public decimal? AdjAmt { get; set; }

    public decimal? NetAmt { get; set; }

    public decimal? Damount { get; set; }

    public decimal? Bamount { get; set; }

    public decimal? Edamount { get; set; }

    public string? Remark { get; set; }

    public decimal? DetNo { get; set; }

    public string? Dtp { get; set; }

    public int? DacYear { get; set; }

    public decimal? DetNoAccode { get; set; }

    public string? Dtpaccode { get; set; }

    public int? DacYearAccode { get; set; }

    public string? Luser { get; set; }

    public DateTime? TrnTime { get; set; }

    public string? Prflag { get; set; }

    public bool? IsCashCharge { get; set; }

    public decimal? DrAndCrPer { get; set; }

    public int? JvseqNo { get; set; }

    public string? DtypeAccode { get; set; }

    public string? PlsMin { get; set; }

    public bool? IsTransfered { get; set; }

    public decimal? LtrnNo { get; set; }

    public short? LsrNo { get; set; }
}
