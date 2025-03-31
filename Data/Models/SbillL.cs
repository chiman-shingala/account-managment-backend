using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class SbillL
{
    public int TrnNo { get; set; }

    public int SrNo { get; set; }

    public int AcYear { get; set; }

    public string CompCode { get; set; } = null!;

    public DateTime? TrnDate { get; set; }

    public string? SCode { get; set; }

    public short? QCode { get; set; }

    public short? CCode { get; set; }

    public short? SzCode { get; set; }

    public decimal? SCarat { get; set; }

    public decimal? RCarat { get; set; }

    public decimal? Conv { get; set; }

    public string? CnCy { get; set; }

    public decimal? Lp1 { get; set; }

    public decimal? Lt1 { get; set; }

    public decimal? Lp2 { get; set; }

    public decimal? Lt2 { get; set; }

    public decimal? Lp3 { get; set; }

    public decimal Lt3 { get; set; }

    public decimal? Amount { get; set; }

    public string? Rem { get; set; }

    public decimal? Srate { get; set; }

    public string? BrCode { get; set; }

    public decimal? Brper { get; set; }

    public decimal? Bramount { get; set; }

    public string? ICode { get; set; }

    public string? DCode { get; set; }

    public string? SnCode { get; set; }

    public string? Pid { get; set; }

    public string? Stype { get; set; }

    public decimal? CertAmt { get; set; }

    public decimal? NcertAmt { get; set; }

    public string? Otype { get; set; }

    public decimal? Pdis { get; set; }

    public decimal? PdisW { get; set; }

    public decimal? PdisPer { get; set; }

    public decimal? Gamount { get; set; }

    public string? MemoOut { get; set; }

    public int? MtrnNo { get; set; }

    public int? MsrNo { get; set; }

    public int? MacYear { get; set; }

    public DateTime? TrnTime { get; set; }

    public string? Desc1 { get; set; }

    public decimal? AvgRate { get; set; }

    public decimal? OrgAvgRate { get; set; }

    public decimal? CommPer { get; set; }

    public decimal? CommAmt { get; set; }

    public decimal? CurrCost { get; set; }

    public string? RefType { get; set; }

    public int? RefAcYear { get; set; }

    public int? RefTrnNo { get; set; }

    public int? RefSrNo { get; set; }

    public decimal? VatPer { get; set; }

    public decimal? VatAmt { get; set; }

    public int? ImpNo { get; set; }

    public string? ImpFor { get; set; }

    public string? ImpInvNo { get; set; }

    public decimal? ImpStkCts { get; set; }

    public decimal? Pcs { get; set; }

    public string? ForDesc { get; set; }
}
