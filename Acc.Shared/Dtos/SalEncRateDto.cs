using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Shared.Dtos
{
	public class SalEncRateDto
	{
		public string Comp_Code { get; set; } = null!;

		public string Digit { get; set; } = null!;

		public string? EncVal { get; set; }
	}
}
