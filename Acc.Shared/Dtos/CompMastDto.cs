using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Acc.Shared.Dtos
{
	public class CompMastDto
	{		
		public string Comp_Code { get; set; } = null!;

		public string? Comp_Name { get; set; }

		public string? Type { get; set; }

		public short? Ord { get; set; }

		public short? DecimalValue { get; set; }
	}
}
