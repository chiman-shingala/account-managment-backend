using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Shared.Dtos
{
	public class PacketOpnDispDto
	{
		public string? PId { get; set; }
		public string? Descr { get; set; }
		public decimal? Carat { get; set; }
		public decimal? Rate { get; set; }
		public string? CnCy { get; set; }
		public decimal? Conv { get; set; }
		public decimal? Amount { get; set; }
		public string? Oper { get; set; }
		public string? LUser { get; set; }
		public string? C_Name { get; set; }
		public string? S_Name { get; set; }
		public string? Q_Name { get; set; }
		public string? I_Name { get; set; }
		public string? D_Name { get; set; }
		public string? SN_Name { get; set; }
		public string? SZ_Name { get; set; }
		public string? ParPktName { get; set; }
	}
}
