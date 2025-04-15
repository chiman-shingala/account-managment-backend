using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Shared.Dtos
{
	public class TBIncMastDto
	{
		public short Tbin_Code { get; set; }

		public string? Tbin_Name { get; set; }

		public decimal? Per { get; set; }

		public string? SortName { get; set; }

		public short? Ord { get; set; }
	}
}
