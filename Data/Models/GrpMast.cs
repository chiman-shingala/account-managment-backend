using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class GrpMast
{
    public string GrCode { get; set; } = null!;

    public string? GrName { get; set; }

    public string? Type { get; set; }

    public short? Ord { get; set; }
}
