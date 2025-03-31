using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class UserRep
{
    public int Id { get; set; }

    public string UserId { get; set; } = null!;

    public DateTime Rdate { get; set; }

    public string? CustName { get; set; }

    public string? PName { get; set; }

    public string? Demand { get; set; }

    public DateTime? Rtime { get; set; }

    public string? Remark { get; set; }

    public string? Udemand { get; set; }
}
