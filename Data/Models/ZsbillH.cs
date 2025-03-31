using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class ZsbillH
{
    public int Idn { get; set; }

    public decimal TrnNo { get; set; }

    public string? InvNo { get; set; }

    public DateTime? TrnDate { get; set; }

    public string? PCode { get; set; }

    public decimal? Conv { get; set; }

    public string? CnCy { get; set; }

    public decimal? SCarat { get; set; }

    public decimal? Amount { get; set; }

    public decimal? Bramount { get; set; }

    public decimal? NetAmt { get; set; }

    public decimal? PayAmt { get; set; }

    public string? OutOk { get; set; }

    public int? DueDay { get; set; }

    public DateTime? DueDate { get; set; }

    public string? Remark { get; set; }

    public string? PrCode { get; set; }

    public string? Stype { get; set; }

    public string? Duser { get; set; }

    public string? CompName { get; set; }

    public DateTime? Ddate { get; set; }

    public DateTime? Dtime { get; set; }

    public int? AtrnNo { get; set; }

    public string? PrName { get; set; }

    public string? ParName { get; set; }

    public decimal? AddLessAmt { get; set; }
}
