using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Shared.Dtos
{
	public class ParPktMastDto
	{
		public string ParPid { get; set; } = null!;

		public string Comp_Code { get; set; } = null!;

		public string? ParPidName { get; set; }

		public int? C_Code { get; set; }

		public int? Q_Code { get; set; }

		public int? Ord { get; set; }
	}
}
