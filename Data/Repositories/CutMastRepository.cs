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
	public class CutMastRepository : ICutMastRepository
	{
		private readonly IDRepository _dRepository;

		public CutMastRepository(IDRepository dRepository)
		{
			_dRepository = dRepository;
		}
		public async Task<List<CutMastDto>> GetAllCuts()
		{
			return await _dRepository.GetAll<CutMastDto>("SP_MastCutMastFill");
		}
		public async Task<int> AddCut(CutMastDto cutMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_CutMastSave", cutMast);
		}
		public async Task<int> UpdateCut(CutMastDto cutMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_CutMastSave", cutMast);
		}
		public async Task<int> DeleteCut(short CT_Code)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_UtilCutMastCutDel", new { CT_Code });
		}
	}
}
