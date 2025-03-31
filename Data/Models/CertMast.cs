using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class CertMast
{
    public short CrCode { get; set; }

    public string? CrName { get; set; }

    public decimal? Per { get; set; }

    public short? Ord { get; set; }
}
