using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class JouRefNo
{
    public int TrnNo { get; set; }

    public int AcYear { get; set; }

    public string CompCode { get; set; } = null!;

    public int DetNo { get; set; }

    public string Dtp { get; set; } = null!;

    public int DacYear { get; set; }

    public decimal SrNo { get; set; }

    public decimal? Amount { get; set; }

    public string? InvNo { get; set; }
}
