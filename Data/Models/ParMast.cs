using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class ParMast
{
    public string PCode { get; set; } = null!;

    public int AcYear { get; set; }

    public string CompCode { get; set; } = null!;

    public string? PName { get; set; }

    public string? GrCode { get; set; }

    public string? PType { get; set; }

    public decimal? Oamount { get; set; }

    public decimal? Conv { get; set; }

    public short? Ord { get; set; }

    public string? Remark { get; set; }

    public decimal? OamountL { get; set; }

    public decimal? Limit { get; set; }

    public byte[]? Ptag { get; set; }

    public byte[]? Pphoto { get; set; }

    public int? AgrCode { get; set; }

    public string? VatNo { get; set; }

    public string? CnCy { get; set; }

    public bool? IpettyCash { get; set; }

    public decimal? Btconv { get; set; }

    public bool? BtsameCur { get; set; }

    public decimal? LabourRate { get; set; }

    public string? Grading { get; set; }

    public bool? SkipBillOs { get; set; }
}
