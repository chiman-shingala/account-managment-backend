using Acc.Data.Interfaces;
using Acc.Data.Repository.Interface;
using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Repositories
{
	public class GrpMastRepository : IGrpMastRepository
	{
		private readonly IDRepository _dRepository;

		public GrpMastRepository(IDRepository dRepository)
		{
			_dRepository = dRepository;
		}
		public async Task<List<GrpMastDto>> GetAllGroup()
		{
			return await _dRepository.GetAll<GrpMastDto>("SP_MastGrpMastFill");
		}
		public async Task<int> AddGroup(GrpMastDto grpMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_UtilGrpMastCreateGrp", grpMast);
		}
		public async Task<int> UpdateGroup(GrpMastDto grpMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_UtilGrpMastUpdateGrp", grpMast);
		}
		public async Task<int> DeleteGroup(string Gr_Code)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_UtilGrpMastGrpDel", new { Gr_Code });
		}
	}
}
