using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Interfaces
{
	public interface IPktGroupRepository
	{
		Task<List<PktGroupDto>> GetAllPktGroup();
		Task<int> AddPktGroup(PktGroupDto pktGroup);
		Task<int> UpdateGroup(PktGroupDto pktGroup);
		Task<int> DeleteGroup(string Gr_Code);
	}
}
