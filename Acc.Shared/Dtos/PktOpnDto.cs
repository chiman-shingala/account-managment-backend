using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Shared.Dtos
{
	public class PktOpnDto
	{
		public string? PId { get; set; }
		public decimal? Carat { get; set; }
		public decimal? Rate { get; set; }
		public string? CnCy { get; set; }
		public decimal? Conv { get; set; }
		public decimal? Amount { get; set; }
		public string? Comp_Code { get; set; }
		public string? Oper { get; set; }
		public string? LUser { get; set; }
		public string? PK_PId { get; set; }
		public int? AcYear { get; set; }
		public DateTime? TrnDate { get; set; }
		public string? S_Code { get; set; } = string.Empty;
		public short? Q_Code { get; set; } = 0;
		public short? C_Code { get; set; } = 0;
		public short? SZ_Code { get; set; } = 0;
		public string? Descr { get; set; } = string.Empty;
		public string? ParPid { get; set; } = string.Empty;
		public string? PG_Code { get; set; } = string.Empty;
	}
}
