using Acc.Data.Interfaces;
using Acc.Data.Repositories;
using Acc.Services.Interfaces;
using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Services
{
	public class PktGroupService : IPktGroupService
	{
		private readonly IPktGroupRepository _pktGroup;

		public PktGroupService(IPktGroupRepository pktGroup)
		{
			_pktGroup = pktGroup;
		}
		public async Task<List<PktGroupDto>> GetAllPktGroup()
		{
			return await _pktGroup.GetAllPktGroup();
		}
		public async Task<int> AddPktGroup(PktGroupDto pktGroup)
		{
			return await _pktGroup.AddPktGroup(pktGroup);
		}
		public async Task<int> UpdatePktGroup(PktGroupDto pktGroup)
		{
			return await _pktGroup.UpdateGroup(pktGroup);
		}
		public async Task<int> DeletePktGroup(string PG_Code)
		{
			return await _pktGroup.DeleteGroup(PG_Code);
		}
	}
}
