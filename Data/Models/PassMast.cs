using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class PassMast
{
    public string UserId { get; set; } = null!;

    public string? Password { get; set; }

	public string? Cat { get; set; }
}
