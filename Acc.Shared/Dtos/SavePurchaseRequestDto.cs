using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Shared.Dtos
{
	public class SavePurchaseRequestDto
	{
		public int TrnNo { get; set; }
		public int AcYear { get; set; } 
		public string? Comp_Code { get; set; }
		public string? Oper { get; set; } 
		public string? InvNo { get; set; }
		public DateTime TrnDate { get; set; }
		public string? P_Code { get; set; } 
		public decimal Conv { get; set; }
		public string? CnCy { get; set; } 
		public decimal S_Carat { get; set; } 
		public decimal Amount { get; set; } 
		public decimal BrAmount { get; set; }
		public decimal NetAmt { get; set; } 
		public string? B_Code { get; set; } 
		public decimal TermAmt1 { get; set; } 
		public decimal TermAmt2 { get; set; } 
		public decimal TermAmt3 { get; set; } 
		public decimal TermAmt4 { get; set; } 
		public decimal TermAmt5 { get; set; } 
		public decimal PayAmt { get; set; }
		public string? OutOk { get; set; }
		public int DueDay { get; set; }
		public DateTime DueDate { get; set; } 
		public string? Remark { get; set; }
		public string? SType { get; set; }
		public string? OType { get; set; }
		public decimal PDis { get; set; } 
		public decimal PCom { get; set; } 
		public int Term2 { get; set; } 
		public int Term3 { get; set; } 
		public int Term4 { get; set; } 
		public int Term5 { get; set; }
		public decimal AmtDiff { get; set; } 
		public string? Luser { get; set; }
		public bool CanInv { get; set; } 
		public DateTime TrnTime { get; set; }
		public int PRTrnNo { get; set; } 
		public int? PRAcYear { get; set; } 
		public string? PrcompCode { get; set; }
		public string? PRInvNo { get; set; } 
		public decimal PRAmount { get; set; } 
		public decimal AdvReceived { get; set; } 
		public string? BR_Code { get; set; } 
		public decimal BrPer { get; set; } 
		public decimal LP1 { get; set; } 
		public decimal LT1 { get; set; } 
		public decimal LP2 { get; set; } 
		public decimal LT2 { get; set; } 
		public string? BOutOk { get; set; }
		public decimal BPayAmt { get; set; }
		public bool IsBreaking { get; set; } 
		public string? DP_Code { get; set; } 
		public bool IsBill { get; set; } 
		public bool IsPending { get; set; } 
		public string? IsChg { get; set; } 
		public decimal? Aconv { get; set; }
		public decimal? PConv { get; set; }
		public string? Pid { get; set; }
		public string? CompName { get; set; }
		public DateTime CDate { get; set; }
		public DateTime CTime { get; set; }
		public bool Confirmed { get; set; }
		public List<CheckAvgRateDto>? checkAvgRates { get; set; }
		public List<PurchaseEntryDetailDto>? PurchaseEntryDetails { get; set; }
	}
}
