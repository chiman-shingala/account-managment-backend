using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Shared.Dtos
{
	public class PerMastDto
	{
		public string User_Name { get; set; } = null!;

		public string Form_Name { get; set; } = null!;

		public bool? Ins { get; set; }

		public bool? Del { get; set; }

		public bool? Upd { get; set; }

		public bool? Viw { get; set; }

		public string? Pass { get; set; }

		public string? Spass { get; set; }
	}
}
