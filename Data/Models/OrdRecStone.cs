using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class OrdRecStone
{
    public int TrnNo { get; set; }

    public int SrNo { get; set; }

    public string CompCode { get; set; } = null!;

    public int AcYear { get; set; }

    public string Type { get; set; } = null!;

    public string? Pid { get; set; }

    public string? PCode { get; set; }

    public int? ItrnNo { get; set; }

    public DateTime? Idate { get; set; }

    public DateTime? Rdate { get; set; }

    public string? SCode { get; set; }

    public short? QCode { get; set; }

    public short? CCode { get; set; }

    public short? SzCode { get; set; }

    public string? Oper { get; set; }

    public string? Kt { get; set; }

    public decimal? KtConvRate { get; set; }

    public decimal? RecWeight { get; set; }

    public decimal? FinalAftConv { get; set; }

    public string? JewId { get; set; }

    public string? Description { get; set; }

    public string? DCode { get; set; }

    public int? Pcs { get; set; }

    public int? UsedPcs { get; set; }

    public int? PendPcs { get; set; }

    public decimal? Carat { get; set; }

    public decimal? RetCarat { get; set; }

    public decimal? FinalUsedCarat { get; set; }

    public decimal? FinalPendCarat { get; set; }

    public decimal? RetCarat1 { get; set; }

    public DateTime? RetDate1 { get; set; }

    public decimal? RetCarat2 { get; set; }

    public DateTime? RetDate2 { get; set; }

    public decimal? RetCarat3 { get; set; }

    public DateTime? RetDate3 { get; set; }

    public decimal? RetCarat4 { get; set; }

    public DateTime? RetDate4 { get; set; }

    public decimal? RetCarat5 { get; set; }

    public DateTime? RetDate5 { get; set; }

    public string? CnCy { get; set; }

    public decimal? Conv { get; set; }

    public decimal? Rate { get; set; }

    public decimal? Amount { get; set; }

    public decimal? OrgAvgRate { get; set; }

    public decimal? LabourRate { get; set; }

    public decimal? LabourAmount { get; set; }

    public string? Luser { get; set; }

    public DateTime? TrnTime { get; set; }
}
