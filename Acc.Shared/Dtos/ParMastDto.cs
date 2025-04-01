using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Shared.Dtos
{
	public class ParMastDto
	{
		public string P_Code { get; set; } = null!;

		public int AcYear { get; set; }

		public string Comp_Code { get; set; } = null!;

		public string? P_Name { get; set; }

		public string? Gr_Code { get; set; }

		public string? P_Type { get; set; }

		public decimal? Oamount { get; set; }

		public decimal? Conv { get; set; }

		public short? Ord { get; set; }

		public string? Remark { get; set; }

		public decimal? OamountL { get; set; }

		public decimal? Limit { get; set; }

		public byte[]? Ptag { get; set; }

		public byte[]? Pphoto { get; set; }

		public int? AgrCode { get; set; }

		public string? VatNo { get; set; }

		public string? CnCy { get; set; }

		public bool? IpettyCash { get; set; }

		public decimal? Btconv { get; set; }

		public bool? BtsameCur { get; set; }

		public decimal? LabourRate { get; set; }

		public string? Grading { get; set; }

		public bool? SkipBillOs { get; set; }
	}
}
