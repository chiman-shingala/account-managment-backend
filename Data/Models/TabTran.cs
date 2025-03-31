using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class TabTran
{
    public int? Agrcode { get; set; }

    public string? Agrname { get; set; }

    public int? Grorder { get; set; }

    public string? Pcode { get; set; }

    public string? Pname { get; set; }

    public DateTime? TrnDate { get; set; }

    public decimal? Debit { get; set; }

    public decimal? Credit { get; set; }

    public decimal? OpnAmount { get; set; }
}
