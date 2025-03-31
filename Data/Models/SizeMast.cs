using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class SizeMast
{
    public short SzCode { get; set; }

    public decimal? FSize { get; set; }

    public decimal? TSize { get; set; }

    public string? Desc { get; set; }
}
