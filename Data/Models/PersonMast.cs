using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class PersonMast
{
    public string PrCode { get; set; } = null!;

    public int AcYear { get; set; }

    public string CompCode { get; set; } = null!;

    public string? PrName { get; set; }

    public short? Ord { get; set; }

    public decimal? CertPer { get; set; }

    public decimal? NcertPer { get; set; }

    public string? UserId { get; set; }
}
