using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class TransferTableList
{
    public string TableName { get; set; } = null!;

    public int? Ord { get; set; }

    public bool? IsAcYear { get; set; }

    public bool? IsCompCode { get; set; }
}
