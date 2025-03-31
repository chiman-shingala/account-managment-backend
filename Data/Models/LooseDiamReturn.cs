using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class LooseDiamReturn
{
    public int TrnNo { get; set; }

    public int SrNo { get; set; }

    public string CompCode { get; set; } = null!;

    public int AcYear { get; set; }

    public string Type { get; set; } = null!;

    public string? Pid { get; set; }

    public DateTime? TrnDate { get; set; }

    public string? PCode { get; set; }

    public decimal? PendCarat { get; set; }

    public string? SCode { get; set; }

    public short? QCode { get; set; }

    public short? CCode { get; set; }

    public short? SzCode { get; set; }

    public string? Oper { get; set; }

    public decimal? RetCarat { get; set; }

    public DateTime? RetDate { get; set; }

    public string? Luser { get; set; }

    public DateTime? TrnTime { get; set; }

    public string? Remark { get; set; }

    public decimal? Rate { get; set; }

    public string? CnCy { get; set; }

    public decimal? Conv { get; set; }

    public decimal? Amount { get; set; }
}
