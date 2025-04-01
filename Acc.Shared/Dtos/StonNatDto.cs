using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Shared.Dtos
{
	public class StonNatDto
	{
		public string Sn_Code { get; set; } = null!;

		public string? Sn_Name { get; set; }

		public short? Ord { get; set; }
	}
}
