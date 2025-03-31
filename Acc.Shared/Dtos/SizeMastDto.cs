using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Shared.Dtos
{
	public class SizeMastDto
	{
		public short Sz_Code { get; set; }

		public decimal? F_Size { get; set; }

		public decimal? T_Size { get; set; }

		public string? Desc { get; set; }
	}
}
