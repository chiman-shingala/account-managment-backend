using Acc.Data.Interfaces;
using Acc.Data.Repository.Interface;
using Acc.Shared.Common;
using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Repositories
{
	public class SIncMastRepository : ISIncMastRepository
	{
		private readonly CommonMethods _commonMethods;
		private readonly IDRepository _dRepository;

		public SIncMastRepository(CommonMethods commonMethods,IDRepository dRepository)
		{
			_commonMethods = commonMethods;
			_dRepository = dRepository;
		}
		public async Task<string?> GetSIncPer(int pintSIncCode)
		{
			return await _commonMethods.SearchTextAsync<string>("SIncMast", "SIN_Code", pintSIncCode.ToString(), "Per");
		}
		public async Task<List<SIncMastDto>> GetAllSIncMast()
		{
			return await _dRepository.GetAll<SIncMastDto>("SP_MastSIncMastFill");
		}
		public async Task<int> AddSIncMast(SIncMastDto sIncMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_SIncMastSave", sIncMast);
		}
		public async Task<int> UpdateSIncMast(SIncMastDto sIncMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_SIncMastSave", sIncMast);
		}
		public async Task<int> DeleteSIncMast(short SIN_Code)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_UtilSIncMastDel", new { SIN_Code });
		}
	}
}
