using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Shared.Dtos
{
	public class PktMastDto
	{
		public string PId { get; set; } = null!;
		public string Comp_Code { get; set; } = null!;
		public decimal Carat { get; set; }
		public string? S_Code { get; set; } = null!;
		public short? Q_Code { get; set; }
		public short? C_Code { get; set; }
		public short CT_Code { get; set; }
		public short Po_Code { get; set; }
		public short Sy_Code { get; set; }
		public decimal Rap { get; set; }
		public decimal Per { get; set; }
		public decimal Rate { get; set; }
		public short FL_Code { get; set; }
		public short TIN_Code { get; set; }
		public short SIN_Code { get; set; }
		public short BIN_Code { get; set; }
		public short SBIN_Code { get; set; }
		public short OIN_Code { get; set; }
		public short SOIN_Code { get; set; }
		public short LU_Code { get; set; }
		public short EF_Code { get; set; }
		public short RIN_Code { get; set; }
		public short CU_Code { get; set; }
		public short BRN_Code { get; set; }
		public short HA_Code { get; set; }
		public short CR_Code { get; set; }
		public string CertNo { get; set; } = string.Empty;
		public string Descr { get; set; } = string.Empty;
		public decimal Diameter { get; set; }
		public decimal TotDepth { get; set; }
		public decimal Table1 { get; set; }
		public decimal Girdle { get; set; }
		public decimal CAngle { get; set; }
		public decimal CHeight { get; set; }
		public decimal PAngle { get; set; }
		public decimal PHeight { get; set; }
		public decimal Height { get; set; }
		public decimal Length { get; set; }
		public decimal Width { get; set; }
		public decimal Ratio { get; set; }
		public short SPkt { get; set; }
		public string SN_Code { get; set; } = null!;
		public string BRO_Code { get; set; } = null!;
		public string I_Code { get; set; } = null!;
		public string D_Code { get; set; } = null!;
		public string Oper { get; set; } = null!;
		public short? SZ_Code { get; set; }
		public decimal Margin { get; set; }
		public string CnCy { get; set; } = null!;
		public decimal Conv { get; set; }
		public decimal CurCost { get; set; }
		public decimal AvgCost { get; set; }
		public decimal SRate { get; set; }
		public decimal SRateMin { get; set; }
		public decimal CrtMin { get; set; }
		public decimal CrtMax { get; set; }
		public string SalCurSym { get; set; } = null!;
		public decimal Quan { get; set; }
		public int GR_CodeK { get; set; }
		public int GR_CodeN { get; set; }
		public string RFIDTag { get; set; } = null!;
		public decimal GWeight { get; set; } = 0;
		public string ParPId { get; set; } = null!;
		public string PG_Code { get; set; } = string.Empty;
		public string Reference { get; set; } = string.Empty;
		public int AcYear { get; set; }
	}
}
