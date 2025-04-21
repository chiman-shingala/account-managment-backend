using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Interfaces.Transaction
{
	public interface IPacketOpnService
	{
		Task<List<PacketOpnDispDto>> GetPacketOpn(string PId, string Comp_Code, string Oper, int AcYear);
		Task<int> AddPacketOpn(PktOpnDto pktOpn);
		Task<int> UpdatePacketOpn(PktOpnDto pktOpn);
	}
}
