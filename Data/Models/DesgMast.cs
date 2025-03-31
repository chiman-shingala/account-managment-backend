using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class DesgMast
{
    public string DCode { get; set; } = null!;

    public string? DName { get; set; }

    public short? Ord { get; set; }
}
