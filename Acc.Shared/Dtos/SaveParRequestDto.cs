using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Shared.Dtos
{
	public class SaveParRequestDto
	{
		public ParMastDto? ParMast { get; set; }
		public PCompMastDto? PCompMast { get; set; }
		public SaveParPersonRequestDto? ParPersons { get; set; }
	}
}
