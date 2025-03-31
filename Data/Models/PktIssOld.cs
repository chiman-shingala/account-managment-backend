using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class PktIssOld
{
    public string Pid { get; set; } = null!;

    public int DetNo { get; set; }

    public string CompCode { get; set; } = null!;

    public DateTime Idate { get; set; }

    public string? PrCode { get; set; }

    public DateTime? Itime { get; set; }

    public int? Ord { get; set; }

    public string? Luser { get; set; }

    public string? Remark { get; set; }

    public bool? PktRec { get; set; }

    public string? Descr { get; set; }

    public decimal? Carat { get; set; }

    public string? Oper { get; set; }
}
