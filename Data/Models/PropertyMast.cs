using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class PropertyMast
{
    public string PropId { get; set; } = null!;

    public decimal? PropValue { get; set; }

    public string? PropText { get; set; }
}
