using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class JewWsl
{
    public int TrnNo { get; set; }

    public int SrNo { get; set; }

    public string CompCode { get; set; } = null!;

    public string Oper { get; set; } = null!;

    public DateTime? TrnDate { get; set; }

    public DateTime? TrnTime { get; set; }

    public string? Pid { get; set; }

    public decimal? Carat { get; set; }

    public string? SCode { get; set; }

    public short? QCode { get; set; }

    public short? CCode { get; set; }

    public string? SnCode { get; set; }

    public decimal? Scarat { get; set; }

    public decimal? Quan { get; set; }

    public decimal? Rate { get; set; }

    public decimal? Amount { get; set; }

    public string? CnCy { get; set; }

    public decimal? Conv { get; set; }
}
