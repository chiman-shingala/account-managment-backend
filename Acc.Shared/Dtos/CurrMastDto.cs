using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Shared.Dtos
{
	public class CurrMastDto
	{
		public string CnCy { get; set; } = null!;

		public decimal? Conv { get; set; }

		public int? Ord { get; set; }

		public string? PcnCy { get; set; }
	}
}
