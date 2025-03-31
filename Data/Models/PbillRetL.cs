using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class PbillRetL
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

    public decimal? Lt3 { get; set; }

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

    public string? Otype { get; set; }

    public string? Desc1 { get; set; }

    public decimal? Pdis { get; set; }

    public decimal? PdisPer { get; set; }

    public decimal? Pcom { get; set; }

    public decimal? PcomPer { get; set; }

    public decimal? Gamount { get; set; }

    public string? PinvNo { get; set; }

    public int? PtrnNo { get; set; }

    public int? PsrNo { get; set; }

    public int? PacYear { get; set; }

    public DateTime? TrnTime { get; set; }
}
