using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Shared.Dtos
{
	public class BrokenMastDto
	{
		public string Bro_Code { get; set; } = null!;

		public string? Bro_Name { get; set; }

		public short? Ord { get; set; }
	}
}
