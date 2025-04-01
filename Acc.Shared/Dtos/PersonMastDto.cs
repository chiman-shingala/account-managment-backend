using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Shared.Dtos
{
	public class PersonMastDto
	{
		public string Pr_Code { get; set; } = null!;

		public int AcYear { get; set; }

		public string Comp_Code { get; set; } = null!;

		public string? Pr_Name { get; set; }

		public short? Ord { get; set; }

		public decimal? CertPer { get; set; }

		public decimal? NcertPer { get; set; }

		public string? UserId { get; set; }
	}
}
