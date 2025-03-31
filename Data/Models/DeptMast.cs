using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class DeptMast
{
    public string DpCode { get; set; } = null!;

    public string DpName { get; set; } = null!;

    public string? Prefix { get; set; }

    public short? Ord { get; set; }
}
