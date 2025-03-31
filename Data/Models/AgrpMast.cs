using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class AgrpMast
{
    public int AgrCode { get; set; }

    public string AgrName { get; set; } = null!;

    public int? AgrUnder { get; set; }

    public string? GrAlias { get; set; }

    public bool GrFix { get; set; }

    public string? GrBspl { get; set; }

    public string? GrReal { get; set; }

    public string? GrBal { get; set; }

    public short? GrOrder { get; set; }

    public short? GrLevel { get; set; }

    public short GrType { get; set; }

    public string? SCode { get; set; }

    public int? FacCode { get; set; }

    public int? TacCode { get; set; }

    public bool? IsSummary { get; set; }
}
