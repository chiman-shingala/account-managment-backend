using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class TblBinaryFile
{
    public string? File { get; set; }

    public string? Path { get; set; }

    public string? Ext { get; set; }

    public long? Size { get; set; }

    public byte[]? Binary { get; set; }
}
