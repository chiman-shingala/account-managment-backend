using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Shared.Dtos
{
	public class PBillHDto
	{
		public string? S_Code { get; set; }
		public short? Q_Code { get; set; }
		public short? C_Code { get; set; }
		public short? Sz_Code { get; set; }
		public decimal? Srate { get; set; }
		public string? Desc1 { get; set; }

		public decimal TrnNo { get; set; }

		public int AcYear { get; set; }

		public string Comp_Code { get; set; } = null!;

		public string? Oper { get; set; }

		public string? InvNo { get; set; }

		public DateTime? TrnDate { get; set; }

		public string? P_Code { get; set; }

		public decimal? Conv { get; set; }

		public string? CnCy { get; set; }

		public decimal? S_Carat { get; set; }

		public decimal? Amount { get; set; }

		public decimal? Bramount { get; set; }

		public decimal? NetAmt { get; set; }

		public string? B_Code { get; set; }

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

		public string? Prcomp_Code { get; set; }

		public string? PrinvNo { get; set; }

		public decimal? Pramount { get; set; }

		public decimal? AdvReceived { get; set; }

		public string? Br_Code { get; set; }

		public decimal? Brper { get; set; }

		public decimal? Lp1 { get; set; }

		public decimal? Lt1 { get; set; }

		public decimal? Lp2 { get; set; }

		public decimal? Lt2 { get; set; }

		public string? BoutOk { get; set; }

		public decimal? BpayAmt { get; set; }

		public bool? IsBreaking { get; set; }

		public string? Dp_Code { get; set; }

		public string? Doc_Name { get; set; }

		public string? Doc_ContentType { get; set; }

		public byte[]? DocData { get; set; }

		public int? PrevYearTrnNo { get; set; }

		public bool? IsBill { get; set; }

		public bool? IsPending { get; set; }
		public DateTime CDate { get; set; }
		public string? CompName { get; set; }
		public DateTime CTime { get; set; }
		public string? IsChg { get; set; }
		public string? ParPid { get; set; }
		public string PId { get; set; }
		public decimal? Gamount { get; set; }
		public decimal? AvgRate { get; set; }
		public decimal? OrgAvgRate { get; set; }
	}
}
