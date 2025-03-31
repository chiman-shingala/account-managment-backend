using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class JewCustPkt
{
    public string Pid { get; set; } = null!;

    public string Oper { get; set; } = null!;

    public int? SrNo { get; set; }
}
