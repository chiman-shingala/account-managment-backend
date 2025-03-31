using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class ItemMast
{
    public string ICode { get; set; } = null!;

    public string? IName { get; set; }

    public short? Ord { get; set; }
}
