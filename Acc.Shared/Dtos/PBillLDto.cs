using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Shared.Dtos
{
	public class PBillLDto
	{
		public int TrnNo { get; set; }

		public int SrNo { get; set; }

		public int AcYear { get; set; }

		public string Comp_Code { get; set; } = null!;

		public DateTime? TrnDate { get; set; }

		public string? S_Code { get; set; }

		public short? Q_Code { get; set; }

		public short? C_Code { get; set; }

		public short? Sz_Code { get; set; }

		public decimal? S_Carat { get; set; }

		public decimal? R_Carat { get; set; }

		public decimal? Conv { get; set; }

		public string? CnCy { get; set; }

		public decimal? Lp1 { get; set; }

		public decimal? Lt1 { get; set; }

		public decimal? Lp2 { get; set; }

		public decimal? Lt2 { get; set; }

		public decimal? Lp3 { get; set; }

		public decimal? Lt3 { get; set; }

		public decimal? Amount { get; set; }

		public string? Rem { get; set; }

		public decimal? Srate { get; set; }

		public string? Br_Code { get; set; }

		public decimal? Brper { get; set; }

		public decimal? Bramount { get; set; }

		public string? I_Code { get; set; }

		public string? D_Code { get; set; }

		public string? Sn_Code { get; set; }

		public string? Pid { get; set; }

		public string? Stype { get; set; }

		public string? Otype { get; set; }

		public string? Desc1 { get; set; }

		public decimal? Pdis { get; set; }

		public decimal? PdisPer { get; set; }

		public decimal? Pcom { get; set; }

		public decimal? PcomPer { get; set; }

		public decimal? Gamount { get; set; }

		public decimal? Pcs { get; set; }

		public string? MemoIn { get; set; }

		public int? MtrnNo { get; set; }

		public int? MsrNo { get; set; }

		public int? MacYear { get; set; }

		public DateTime? TrnTime { get; set; }

		public bool? Spkt { get; set; }

		public decimal? AvgRate { get; set; }

		public decimal? OrgAvgRate { get; set; }

		public decimal? VatPer { get; set; }

		public decimal? VatAmt { get; set; }

		public string? ForDesc { get; set; }
		public object? PG_Code { get; set; }
	}
}
