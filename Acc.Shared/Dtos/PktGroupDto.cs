using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Shared.Dtos
{
	public class PktGroupDto
	{
		public string Pg_Code { get; set; } = null!;

		public string Pg_Name { get; set; } = null!;

		public string S_Code { get; set; } = null!;

		public short Sz_Code { get; set; }

		public short C_Code { get; set; }

		public short Q_Code { get; set; }

		public short? Ord { get; set; }
	}
}
