using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class ParPktMast
{
    public string ParPid { get; set; } = null!;

    public string CompCode { get; set; } = null!;

    public string? ParPidName { get; set; }

    public int? CCode { get; set; }

    public int? QCode { get; set; }

    public int? Ord { get; set; }
}
