using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class BrokenMast
{
    public string BroCode { get; set; } = null!;

    public string? BroName { get; set; }

    public short? Ord { get; set; }
}
