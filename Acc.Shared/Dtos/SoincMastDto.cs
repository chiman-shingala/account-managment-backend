using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Shared.Dtos
{
	public class SoincMastDto
	{
		public short Soin_Code { get; set; }

		public string? Soin_Name { get; set; }

		public decimal? Per { get; set; }

		public string? SortName { get; set; }

		public short? Ord { get; set; }
	}
}
