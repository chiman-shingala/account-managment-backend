using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class SpersonMast
{
    public string PrCode { get; set; } = null!;

    public string? PrName { get; set; }

    public bool? Pf { get; set; }

    public bool? Spf { get; set; }

    public short? Ord { get; set; }

    public short? Spord { get; set; }
}
