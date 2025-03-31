using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class OrdH
{
    public decimal TrnNo { get; set; }

    public string CompCode { get; set; } = null!;

    public int AcYear { get; set; }

    public DateTime? OrdDate { get; set; }

    public string? PCode { get; set; }

    public string? Remark { get; set; }

    public decimal? Qty { get; set; }

    public string? CnCy { get; set; }

    public decimal? Conv { get; set; }

    public byte[]? JewSketch { get; set; }

    public string? Oper { get; set; }
}
