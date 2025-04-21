using Acc.Data.Interfaces;
using Acc.Data.Repository.Interface;
using Acc.Shared.Common;
using Acc.Shared.Dtos;

namespace Acc.Data.Repositories
{
	public class HAMastRepository : IHAMastRepository
	{
		private readonly CommonMethods _commonMethods;
		private readonly IDRepository _dRepository;

		public HAMastRepository(CommonMethods commonMethods,IDRepository dRepository)
		{
			_commonMethods = commonMethods;
			_dRepository = dRepository;
		}
		public async Task<string?> GetHAPer(int pintHAIncCode)
		{
			return await _commonMethods.SearchTextAsync<string>("HAMast", "HA_Code", pintHAIncCode.ToString(), "Per");
		}
		public async Task<List<HAMastDto>> GetAllHAMast()
		{
			return await _dRepository.GetAll<HAMastDto>("SP_MastHAMastFill");
		}
		public async Task<int> AddHAMast(HAMastDto hAMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_HAMastSave", hAMast);
		}
		public async Task<int> UpdateHAMast(HAMastDto hAMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_HAMastSave", hAMast);
		}
		public async Task<int> DeleteHAMast(short HA_Code)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_UtilHAMastDel", new { HA_Code });
		}
	}
}
