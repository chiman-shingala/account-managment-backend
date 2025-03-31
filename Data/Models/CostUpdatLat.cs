using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class CostUpdatLat
{
    public int AutoId { get; set; }

    public int SrNo { get; set; }

    public int TrnNo { get; set; }

    public string? Pid { get; set; }

    public string? CompCode { get; set; }

    public DateTime? Cdate { get; set; }

    public DateTime? Ctime { get; set; }

    public decimal? Price { get; set; }

    public decimal? CurAvg { get; set; }

    public string? CnCy { get; set; }

    public decimal? Conv { get; set; }

    public int? AcYear { get; set; }

    public string? PurType { get; set; }

    public string? Luser { get; set; }

    public string? CompName { get; set; }
}
