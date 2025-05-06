using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Shared.Dtos
{
	public class ParMastFillDto
	{
		public string P_Code { get; set; } = string.Empty;
		public bool LastInvDate { get; set; }
		public string GR_Code { get; set; } = string.Empty;
		public string? BankCash { get; set; }
		public int AcYear { get; set; }
		public string Comp_Code { get; set; } = string.Empty;
		public string UserId { get; set; } = string.Empty;
	}
}
