using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class ParPerson
{
    public string PCode { get; set; } = null!;

    public string PrCode { get; set; } = null!;

    public int AcYear { get; set; }

    public string CompCode { get; set; } = null!;
}
