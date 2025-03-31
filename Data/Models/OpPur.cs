using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class OpPur
{
    public int AcYear { get; set; }

    public string CompCode { get; set; } = null!;

    public string? PCode { get; set; }

    public decimal? Amount { get; set; }
}
