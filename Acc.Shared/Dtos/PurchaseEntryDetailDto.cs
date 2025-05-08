using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Shared.Dtos
{
	public class PurchaseEntryDetailDto
	{
		public int AcYear { get; set; }
		public string? Comp_Code { get; set; }
		public int SrNo { get; set; }
		public string? S_Code { get; set; } // Shape Code
		public int Q_Code { get; set; } // Quality Code
		public int C_Code { get; set; } // Color Code
		public int SZ_Code { get; set; } // Size Code
		public double S_Carat { get; set; } // Carat
		public string? Rem { get; set; } // Remarks
		public double Amount { get; set; }
		public double LP1 { get; set; }
		public double LT1 { get; set; }
		public double LP2 { get; set; }
		public double LT2 { get; set; }
		public double SRate { get; set; } // Stone Rate
		public string? I_Code { get; set; } // Item Code
		public string? D_Code { get; set; } // Design Code
		public string? SN_Code { get; set; } 
		public string? PId { get; set; } // Packet ID
		public string? Desc1 { get; set; } // Description
		public double GAmount { get; set; } // Gross Amount
		public double PDis { get; set; } 
		public double PDisPer { get; set; }
		public double PCom { get; set; } 
		public double PComPer { get; set; } 
		public int Pcs { get; set; }
		public string? MemoIn { get; set; } 
		public int MTrnNo { get; set; } 
		public int MSrNo { get; set; } 
		public int MAcYear { get; set; } 
		public int SPkt { get; set; } 
		public double AvgRate { get; set; }
		public string? ParPid { get; set; } 
		public string? PG_Code { get; set; } 
		public double VatPer { get; set; }
		public double VatAmt { get; set; } 
		public string? ForDesc { get; set; } 
		public double OrgAvgRate { get; set; }
	}
}
