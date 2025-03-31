using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class Zlog
{
    public string Luser { get; set; } = null!;

    public string CompName { get; set; } = null!;

    public DateTime? Date { get; set; }

    public DateTime? Time { get; set; }
}
