using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Shared.Dtos
{
	public class SaveParPersonRequestDto
	{
		public string? AcYear { get; set; }
		public string? Comp_Code { get; set; }
		public List<ParPersonDto>? Persons { get; set; }
	}
}
