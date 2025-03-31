using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class ZlogAppInRet
{
    public int Idn { get; set; }

    public decimal TrnNo { get; set; }

    public int SrNo { get; set; }

    public int AcYear { get; set; }

    public string CompCode { get; set; } = null!;

    public string? Oper { get; set; }

    public DateTime? TrnDate { get; set; }

    public string? PCode { get; set; }

    public int? DueDay { get; set; }

    public DateTime? DueDate { get; set; }

    public string? Remark { get; set; }

    public string? Memo { get; set; }

    public string? PrCode { get; set; }

    public string? Luser { get; set; }

    public string? SCode { get; set; }

    public short? QCode { get; set; }

    public short? CCode { get; set; }

    public short? SzCode { get; set; }

    public decimal? Carat { get; set; }

    public decimal? RCarat { get; set; }

    public decimal? Conv { get; set; }

    public string? CnCy { get; set; }

    public decimal? Amount { get; set; }

    public decimal? Srate { get; set; }

    public string? ICode { get; set; }

    public string? DCode { get; set; }

    public string? SnCode { get; set; }

    public string? Pid { get; set; }

    public string? Desc1 { get; set; }

    public int? Pcs { get; set; }

    public string? Operation { get; set; }

    public string? Odetail { get; set; }

    public string? DelLuser { get; set; }

    public string? DelCompName { get; set; }

    public DateTime? DelDate { get; set; }

    public DateTime? DelTime { get; set; }

    public DateTime? TrnTime { get; set; }

    public int? AtrnNo { get; set; }

    public int? AsrNo { get; set; }

    public string? Amemo { get; set; }

    public int? AacYear { get; set; }
}
