using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class ProughH
{
    public int TrnNo { get; set; }

    public int AcYear { get; set; }

    public string CompCode { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string? PCode { get; set; }

    public string? InvNo { get; set; }

    public string? Oper { get; set; }

    public DateTime? TrnDate { get; set; }

    public string? CnCy { get; set; }

    public decimal? Conv { get; set; }

    public decimal? TotTrCarat { get; set; }

    public decimal? TotPcarat { get; set; }

    public decimal? TotRcarat { get; set; }

    public decimal? TotMkamt { get; set; }

    public string? Remark { get; set; }

    public string? Luser { get; set; }

    public DateTime? TrnTime { get; set; }
}
