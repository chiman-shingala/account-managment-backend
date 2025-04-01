using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Shared.Dtos
{
	public class CertMastDto
	{
		public short Cr_Code { get; set; }

		public string? Cr_Name { get; set; }

		public decimal? Per { get; set; }

		public short? Ord { get; set; }
	}
}
