using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class CompMast
{
    public string CompCode { get; set; } = null!;

    public string? CompName { get; set; }

    public string? Type { get; set; }

    public short? Ord { get; set; }

    public short? DecimalValue { get; set; }
}
