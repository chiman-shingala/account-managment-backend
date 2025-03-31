using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Shared.Dtos
{
	public class AccYearDto
	{
		public string Comp_Code { get; set; } = null!;

		public int AcYear { get; set; }

		public DateTime? FtrnDate { get; set; }

		public DateTime? TtrnDate { get; set; }

		public string? Remark { get; set; }
	}
}
