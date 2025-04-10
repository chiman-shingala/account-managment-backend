using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Shared.Dtos
{
	public class PacketEntDto
	{
		public string S_Code { get; set; } = string.Empty;
		public int C_Code { get; set; }
		public int Q_Code { get; set; }
		public double Carat { get; set; }
		public int FL_Code { get; set; }
		public int CT_Code { get; set; }
	}
}
