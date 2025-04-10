using Acc.Data.Interfaces.IMaster;
using Acc.Data.Repository.Interface;
using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Repositories.Master
{
	public class PktGroupRepository : IPktGroupRepository
	{
		private readonly IDRepository _dRepository;

		public PktGroupRepository(IDRepository dRepository)
		{
			_dRepository = dRepository;
		}
		public async Task<List<PktGroupDto>> GetAllPktGroup()
		{
			return await _dRepository.GetAll<PktGroupDto>("SP_PktGroupMastFill");
		}
		public async Task<int> AddPktGroup(PktGroupDto pktGroup)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_PktGroupSave", pktGroup);
		}
		public async Task<int> UpdateGroup(PktGroupDto pktGroup)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_PktGroupSave", pktGroup);
		}
		public async Task<int> DeleteGroup(string PG_Code)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_UtilPktGroupDel", new { PG_Code });
		}
	}
}
