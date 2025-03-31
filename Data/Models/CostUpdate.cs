using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class CostUpdate
{
    public int AutoId { get; set; }

    public int? TrnNo { get; set; }

    public int? SrNo { get; set; }

    public string? Pid { get; set; }

    public string? CompCode { get; set; }

    public int? AcYear { get; set; }

    public DateTime? Cdate { get; set; }

    public DateTime? Ctime { get; set; }

    public decimal? Price { get; set; }

    public string? CurAvg { get; set; }

    public string? CnCy { get; set; }

    public decimal? Conv { get; set; }

    public string? PurType { get; set; }

    public string? Luser { get; set; }

    public string? CompName { get; set; }

    public decimal? OrgPrice { get; set; }

    public decimal? DiffAmt { get; set; }

    public decimal? StkCts { get; set; }
}
