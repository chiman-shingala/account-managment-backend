using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Shared.Dtos
{
	public class EfacMastDto
	{
		public short Ef_Code { get; set; }

		public string? Ef_Name { get; set; }

		public decimal? Per { get; set; }

		public string? SortName { get; set; }

		public short? Ord { get; set; }
	}
}
