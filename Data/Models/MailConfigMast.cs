using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class MailConfigMast
{
    public string? Smtp { get; set; }

    public int? Port { get; set; }

    public string? FromEmailId { get; set; }

    public string? Password { get; set; }

    public string? CcemailId { get; set; }

    public bool? IsSsl { get; set; }
}
