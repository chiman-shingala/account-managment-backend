using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class PerAprUser
{
    public string UserName { get; set; } = null!;

    public int SrNo { get; set; }

    public bool? Vw { get; set; }

    public string? Pass { get; set; }
}
