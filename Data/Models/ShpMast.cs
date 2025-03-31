using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class ShpMast
{
    public string SCode { get; set; } = null!;

    public string? SName { get; set; }

    public short? Ord { get; set; }
}
