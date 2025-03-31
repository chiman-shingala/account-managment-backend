using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class StonNat
{
    public string SnCode { get; set; } = null!;

    public string? SnName { get; set; }

    public short? Ord { get; set; }
}
