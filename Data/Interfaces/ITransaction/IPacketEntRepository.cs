using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Interfaces.ITransaction
{
	public interface IPacketEntRepository
	{
		Task<int> AddPacketEnt(PktMastDto packetEnt);
		Task<int> UpdatePacketEnt(PktMastDto packetEnt);
		Task<int> DeletePacketEnt(string PId, string Comp_Code);
	}
}
