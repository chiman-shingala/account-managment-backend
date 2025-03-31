using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class ProughL
{
    public int TrnNo { get; set; }

    public int SrNo { get; set; }

    public int AcYear { get; set; }

    public string CompCode { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string? PCode { get; set; }

    public string? Oper { get; set; }

    public DateTime? TrnDate { get; set; }

    public string? SCode { get; set; }

    public short? QCode { get; set; }

    public short? CCode { get; set; }

    public short? SzCode { get; set; }

    public string? CnCy { get; set; }

    public decimal? Conv { get; set; }

    public string? Pid { get; set; }

    public decimal? Carat { get; set; }

    public string? Tpid { get; set; }

    public decimal? TranCarat { get; set; }

    public decimal? TranRate { get; set; }

    public decimal? TranAmt { get; set; }

    public decimal? Pcarat { get; set; }

    public decimal? Rcarat { get; set; }

    public decimal? Mcrate { get; set; }

    public decimal? Mcamt { get; set; }

    public string? Luser { get; set; }

    public DateTime? TrnTime { get; set; }

    public string? Remark { get; set; }

    public int? MtrnNo { get; set; }

    public int? MsrNo { get; set; }

    public int? MacYear { get; set; }

    public string? MemoOut { get; set; }

    public decimal? UsedCarat { get; set; }
}
