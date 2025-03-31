using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Shared.Dtos
{
	public class GrpMastDto
	{
		public string Gr_Code { get; set; } = null!;

		public string? Gr_Name { get; set; }

		public string? Type { get; set; }

		public short? Ord { get; set; }
	}
}
