using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class AccYear
{
    public string CompCode { get; set; } = null!;

    public int AcYear { get; set; }

    public DateTime? FtrnDate { get; set; }

    public DateTime? TtrnDate { get; set; }

    public string? Remark { get; set; }
}
