using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Interfaces.Transaction
{
	public interface IPacketEntService
	{
		Task<double> FindRapAsync(PacketEntDto pc1);
		Task<double> FindRapDisc(PacketEntDto pc1);
		Task<double> FindFluoDisc(PacketEntDto pc1);
		Task<RapDiscDetDto> GetRapDetailsAsync(PacketEntDto packet, RapDetailInputDto rapDetail, bool returnDetail = true);
		Task<int> AddPacketEnt(PktMastDto packetEnt);
		Task<int> UpdatePacketEnt(PktMastDto packetEnt);
		Task<int> DeletePacketEnt(string PId, string Comp_Code);
		Task<int> FindNewPId(string Comp_Code);
	}
}
