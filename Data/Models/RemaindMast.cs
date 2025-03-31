using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class RemaindMast
{
    public int RemCode { get; set; }

    public DateTime? RemTime { get; set; }

    public string? Remark { get; set; }

    public bool? IsAlert { get; set; }

    public string? Action { get; set; }
}
