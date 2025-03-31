using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class ZsbillL
{
    public int Idn { get; set; }

    public int TrnNo { get; set; }

    public int SrNo { get; set; }

    public int? SerNo { get; set; }

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

    public decimal? Sper { get; set; }

    public string? BrCode { get; set; }

    public decimal? Brper { get; set; }

    public decimal? Bramount { get; set; }

    public decimal? Cost { get; set; }

    public decimal? Grate { get; set; }

    public decimal? Gper { get; set; }

    public string? PCode { get; set; }

    public decimal? Grap { get; set; }

    public decimal? Ccper { get; set; }

    public decimal? Ccost { get; set; }

    public DateTime? Ddate { get; set; }

    public DateTime? Dtime { get; set; }

    public int? AtrnNo { get; set; }

    public string? SName { get; set; }

    public string? CName { get; set; }

    public string? QName { get; set; }

    public string? BrName { get; set; }

    public decimal? Cper { get; set; }
}
