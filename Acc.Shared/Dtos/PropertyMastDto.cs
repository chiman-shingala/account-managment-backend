using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Shared.Dtos
{
	public class PropertyMastDto
	{
		public string PropId { get; set; } = null!;

		public decimal? PropValue { get; set; }

		public string? PropText { get; set; }
	}
}
