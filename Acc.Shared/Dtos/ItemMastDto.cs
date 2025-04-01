using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Shared.Dtos
{
	public class ItemMastDto
	{
		public string I_Code { get; set; } = null!;

		public string? I_Name { get; set; }

		public short? Ord { get; set; }
	}
}
