using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class OrdL
{
    public int TrnNo { get; set; }

    public int SrNo { get; set; }

    public string CompCode { get; set; } = null!;

    public int AcYear { get; set; }

    public string? Oper { get; set; }

    public DateTime? OrdDate { get; set; }

    public string? PCode { get; set; }

    public decimal? Rate { get; set; }

    public decimal? Qty { get; set; }

    public string? RecNo { get; set; }

    public int? JCode { get; set; }

    public int? FCode { get; set; }

    public decimal? Amount { get; set; }

    public decimal? Carat { get; set; }

    public string? Remark { get; set; }

    public string? SCode { get; set; }

    public short? QCode { get; set; }

    public short? CCode { get; set; }

    public short? SzCode { get; set; }

    public decimal? Conv { get; set; }

    public string? CnCy { get; set; }

    public string? Mtype { get; set; }

    public string? Pid { get; set; }

    public string? MacYear { get; set; }

    public int? MtrnNo { get; set; }

    public int? MsrNo { get; set; }

    public string? ICode { get; set; }

    public string? DCode { get; set; }

    public string? SnCode { get; set; }

    public string? ParPid { get; set; }
}
