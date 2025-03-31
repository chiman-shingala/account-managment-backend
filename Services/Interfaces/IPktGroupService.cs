using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Interfaces
{
	public interface IPktGroupService
	{
		Task<List<PktGroupDto>> GetAllPktGroup();
		Task<int> AddPktGroup(PktGroupDto pktGroup);
		Task<int> UpdatePktGroup(PktGroupDto pktGroup);
		Task<int> DeletePktGroup(string PG_Code);
	}
}
