using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class TaskMast
{
    public int TaskId { get; set; }

    public string UserId { get; set; } = null!;

    public string? Task { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? Remark { get; set; }

    public bool? IsComplete { get; set; }

    public DateTime? TrnDate { get; set; }
}
