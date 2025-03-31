using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class PktGroup
{
    public string PgCode { get; set; } = null!;

    public string PgName { get; set; } = null!;

    public string SCode { get; set; } = null!;

    public short SzCode { get; set; }

    public short CCode { get; set; }

    public short QCode { get; set; }

    public short? Ord { get; set; }
}
