using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class TempAbillInL
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

    public decimal? Carat { get; set; }

    public decimal? Conv { get; set; }

    public string? CnCy { get; set; }

    public decimal? Amount { get; set; }

    public string? Rem { get; set; }

    public decimal? Srate { get; set; }

    public string? ICode { get; set; }

    public string? DCode { get; set; }

    public string? SnCode { get; set; }

    public string? Pid { get; set; }

    public string? Desc1 { get; set; }

    public string? Oper { get; set; }

    public int? Pcs { get; set; }
}
