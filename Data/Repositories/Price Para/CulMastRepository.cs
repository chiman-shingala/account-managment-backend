using Acc.Data.Interfaces.IMaster;
using Acc.Data.Repository.Interface;
using Acc.Shared.Common;
using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Repositories.Master
{
	public class CulMastRepository : ICulMastRepository
	{
		private readonly CommonMethods _commonMethods;
		private readonly IDRepository _dRepository;

		public CulMastRepository(CommonMethods commonMethods,IDRepository dRepository)
		{
			_commonMethods = commonMethods;
			_dRepository = dRepository;
		}
		public async Task<string?> GetCulPer(int pintCUCode)
		{
			return await _commonMethods.SearchTextAsync<string>("CulMast", "CU_Code", pintCUCode.ToString(), "Per");
		}
		public async Task<List<CulMastDto>> GetAllCulMast()
		{
			return await _dRepository.GetAll<CulMastDto>("SP_MastCulMastFill");
		}
		public async Task<int> AddCulMast(CulMastDto culMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_CulMastSave", culMast);
		}
		public async Task<int> UpdateCulMast(CulMastDto culMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_CulMastSave", culMast);
		}
		public async Task<int> DeleteCulMast(short CU_Code)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_UtilCulMastDel", new { CU_Code });
		}
	}
}
