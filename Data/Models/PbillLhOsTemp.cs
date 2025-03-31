using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class PbillLhOsTemp
{
    public decimal TrnNo { get; set; }

    public int AcYear { get; set; }

    public string CompCode { get; set; } = null!;

    public string? Oper { get; set; }

    public string? InvNo { get; set; }

    public DateTime? TrnDate { get; set; }

    public string? PCode { get; set; }

    public decimal? Conv { get; set; }

    public string? CnCy { get; set; }

    public decimal? SCarat { get; set; }

    public decimal? Amount { get; set; }

    public decimal? Bramount { get; set; }

    public decimal? NetAmt { get; set; }

    public string? BCode { get; set; }

    public decimal? TermAmt1 { get; set; }

    public decimal? TermAmt2 { get; set; }

    public decimal? TermAmt3 { get; set; }

    public decimal? TermAmt4 { get; set; }

    public decimal? TermAmt5 { get; set; }

    public decimal? PayAmt { get; set; }

    public string? OutOk { get; set; }

    public int? DueDay { get; set; }

    public DateTime? DueDate { get; set; }

    public string? Remark { get; set; }

    public string? Stype { get; set; }

    public string? Otype { get; set; }

    public decimal? Pdis { get; set; }

    public decimal? Pcom { get; set; }

    public int? Term2 { get; set; }

    public int? Term3 { get; set; }

    public int? Term4 { get; set; }

    public int? Term5 { get; set; }

    public decimal? AmtDiff { get; set; }

    public string? Luser { get; set; }

    public bool? CanInv { get; set; }

    public DateTime? TrnTime { get; set; }

    public int? PrtrnNo { get; set; }

    public int? PracYear { get; set; }

    public string? PrcompCode { get; set; }

    public string? PrinvNo { get; set; }

    public decimal? Pramount { get; set; }

    public decimal? AdvReceived { get; set; }

    public string? BrCode { get; set; }

    public decimal? Brper { get; set; }

    public decimal? Lp1 { get; set; }

    public decimal? Lt1 { get; set; }

    public decimal? Lp2 { get; set; }

    public decimal? Lt2 { get; set; }

    public string? BoutOk { get; set; }

    public decimal? BpayAmt { get; set; }

    public bool? IsBreaking { get; set; }

    public string? DpCode { get; set; }

    public string? DocName { get; set; }

    public string? DocContentType { get; set; }

    public byte[]? DocData { get; set; }

    public int? PrevYearTrnNo { get; set; }
}
