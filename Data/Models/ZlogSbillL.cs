using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class ZlogSbillL
{
    public int Idn { get; set; }

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

    public string? Oper { get; set; }

    public string? InvNo { get; set; }

    public string? PCode { get; set; }

    public int? DueDay { get; set; }

    public DateTime? DueDate { get; set; }

    public string? Remark { get; set; }

    public string? PrCode { get; set; }

    public bool? CanInv { get; set; }

    public string? Luser { get; set; }

    public string? Operation { get; set; }

    public string? Odetail { get; set; }

    public string? DelLuser { get; set; }

    public string? DelCompName { get; set; }

    public DateTime? DelDate { get; set; }

    public DateTime? DelTime { get; set; }
}
