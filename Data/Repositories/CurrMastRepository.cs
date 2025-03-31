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
	public class CurrMastRepository : ICurrMastRepository
	{
		private readonly IDRepository _dRepository;

		public CurrMastRepository(IDRepository dRepository)
		{
			_dRepository = dRepository;
		}
		public async Task<List<CurrMastDto>> GetAllCurrent()
		{
			return await _dRepository.GetAll<CurrMastDto>("SP_MastCurrMastFill");
		}
		public async Task<int> AddCurrent(CurrMastDto currMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_CurrMastSave", currMast);
		}
		public async Task<int> UpdateCurrent(CurrMastDto currMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_CurrMastSave", currMast);
		}
		public async Task<int> DeleteCurrent(string CnCy)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_UtilCurrMastCurrDel", new { CnCy });
		}
	}
}
