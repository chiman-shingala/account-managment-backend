using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class PerMast
{
    public string UserName { get; set; } = null!;

    public string FormName { get; set; } = null!;

    public bool? Ins { get; set; }

    public bool? Del { get; set; }

    public bool? Upd { get; set; }

    public bool? Viw { get; set; }

    public string? Pass { get; set; }

    public string? Spass { get; set; }
}
