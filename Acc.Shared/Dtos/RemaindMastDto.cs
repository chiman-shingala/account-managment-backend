using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Shared.Dtos
{
	public class RemaindMastDto
	{
		public int Rem_Code { get; set; }

		public DateTime? Rem_Time { get; set; }

		public string? Remark { get; set; }

		public bool? IsAlert { get; set; }

		public string? Action { get; set; }
	}
}
