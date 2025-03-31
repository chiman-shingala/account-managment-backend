using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class PktEntJewImg
{
    public string Pid { get; set; } = null!;

    public string CompCode { get; set; } = null!;

    public string Oper { get; set; } = null!;

    public byte[]? JewImg { get; set; }

    public byte[]? JewThumbnailImg { get; set; }
}
