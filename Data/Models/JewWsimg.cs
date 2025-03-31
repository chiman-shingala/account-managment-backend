using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class JewWsimg
{
    public string Pid { get; set; } = null!;

    public string CompCode { get; set; } = null!;

    public string Oper { get; set; } = null!;

    public byte[]? JewImg { get; set; }
}
