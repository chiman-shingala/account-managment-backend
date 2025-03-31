using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class SalEncRate
{
    public string CompCode { get; set; } = null!;

    public string Digit { get; set; } = null!;

    public string? EncVal { get; set; }
}
