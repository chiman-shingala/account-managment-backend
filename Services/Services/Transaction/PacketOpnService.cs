using Acc.Data.Interfaces.ITransaction;
using Acc.Services.Interfaces.Transaction;
using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Services.Transaction
{
	public class PacketOpnService : IPacketOpnService
	{
		private readonly IPacketOpnRepository _packetOpn;

		public PacketOpnService(IPacketOpnRepository packetOpn)
		{
			_packetOpn = packetOpn;
		}
		public async Task<List<PacketOpnDispDto>> GetPacketOpn(string PId, string Comp_Code, string Oper, int AcYear)
		{
			return await _packetOpn.GetPacketOpn(PId, Comp_Code, Oper, AcYear);
		}
		public async Task<int> AddPacketOpn(PktOpnDto pktOpn)
		{
			return await _packetOpn.AddPacketOpn(pktOpn);
		}
		public async Task<int> UpdatePacketOpn(PktOpnDto pktOpn)
		{
			return await _packetOpn.UpdatePacketOpn(pktOpn);
		}		
	}
}
