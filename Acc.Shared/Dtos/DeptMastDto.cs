using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Shared.Dtos
{
	public class DeptMastDto
	{
		public string Dp_Code { get; set; } = null!;

		public string Dp_Name { get; set; } = null!;

		public string? Prefix { get; set; }

		public short? Ord { get; set; }
	}
}
