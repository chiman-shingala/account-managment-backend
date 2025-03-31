using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class AbillInRetH
{
    public decimal TrnNo { get; set; }

    public int AcYear { get; set; }

    public string CompCode { get; set; } = null!;

    public string? Oper { get; set; }

    public DateTime? TrnDate { get; set; }

    public string? PCode { get; set; }

    public decimal? Conv { get; set; }

    public string? CnCy { get; set; }

    public decimal? RCarat { get; set; }

    public decimal? Amount { get; set; }

    public decimal? NetAmt { get; set; }

    public int? DueDay { get; set; }

    public DateTime? DueDate { get; set; }

    public string? Remark { get; set; }

    public string? Memo { get; set; }

    public string? PrCode { get; set; }

    public string? Luser { get; set; }

    public DateTime? TrnTime { get; set; }
}
