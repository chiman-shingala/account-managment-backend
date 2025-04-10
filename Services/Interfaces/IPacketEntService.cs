using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Interfaces
{
	public interface IPacketEntService
	{
		Task<double> FindRapAsync(PacketEntDto pc1);
		Task<double> FindRapDisc(PacketEntDto pc1);
		Task<double> FindFluoDisc(PacketEntDto pc1);
		Task<RapDiscDetDto> GetRapDetailsAsync(PacketEntDto packet, RapDetailInputDto rapDetail, bool returnDetail = true);
	}
}
