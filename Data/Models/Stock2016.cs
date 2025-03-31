using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class Stock2016
{
    public string Pid { get; set; } = null!;

    public string Sname { get; set; } = null!;

    public string SizeDesc { get; set; } = null!;

    public string Cname { get; set; } = null!;

    public string Qname { get; set; } = null!;

    public string Crname { get; set; } = null!;

    public decimal MemoInCrt { get; set; }

    public decimal StockCrt { get; set; }

    public decimal? CostPrice { get; set; }

    public decimal? SalesPrice { get; set; }

    public decimal MemoOutCrt { get; set; }

    public string? Descr { get; set; }

    public decimal? Amount { get; set; }

    public decimal Stock { get; set; }

    public string? ParPid { get; set; }

    public string? PgCode { get; set; }

    public decimal? CostAmt { get; set; }

    public decimal? SalAmt { get; set; }
}
