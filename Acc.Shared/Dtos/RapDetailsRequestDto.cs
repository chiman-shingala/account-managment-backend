using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Shared.Dtos
{
	public class RapDetailsRequestDto
	{
		public PacketEntDto Packet { get; set; }
		public RapDetailInputDto Codes { get; set; }
		public bool ReturnDetail { get; set; }
	}
}
