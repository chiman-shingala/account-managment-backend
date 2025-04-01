using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Shared.Dtos
{
	public class KtMastDto
	{
		public DateTime? Date { get; set; }

		public string Kt { get; set; } = null!;

		public decimal? GoldPrice { get; set; }

		public decimal? Per { get; set; }
	}
}
