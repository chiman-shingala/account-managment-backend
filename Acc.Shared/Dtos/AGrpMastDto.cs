using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Shared.Dtos
{
	public class AGrpMastDto
	{
		public int Agr_Code { get; set; }
		public string Agr_Name { get; set; } = null!;
		public int? Agr_Under { get; set; }
		public bool Gr_Fix { get; set; }
		public short? Gr_Order { get; set; }
		public short Gr_Type { get; set; }
		public bool? IsSummary { get; set; }
	}
}
