using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class FluoDisc
{
    public short SzCode { get; set; }

    public short CCode { get; set; }

    public string SCode { get; set; } = null!;

    public short FlCode { get; set; }

    public decimal? Q1 { get; set; }

    public decimal? Q2 { get; set; }

    public decimal? Q3 { get; set; }

    public decimal? Q4 { get; set; }

    public decimal? Q5 { get; set; }

    public decimal? Q6 { get; set; }

    public decimal? Q7 { get; set; }

    public decimal? Q8 { get; set; }

    public decimal? Q9 { get; set; }

    public decimal? Q10 { get; set; }

    public decimal? Q11 { get; set; }
}
