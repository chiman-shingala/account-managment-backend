using Acc.Data.Interfaces;
using Acc.Data.Repository.Interface;
using Acc.Shared.Common;
using Acc.Shared.Dtos;

namespace Acc.Data.Repositories
{
	public class TBIncMastRepository : ITBIncMastRepository
	{
		private readonly CommonMethods _commonMethods;
		private readonly IDRepository _dRepository;

		public TBIncMastRepository(CommonMethods commonMethods,IDRepository dRepository)
		{
			_commonMethods = commonMethods;
			_dRepository = dRepository;
		}
		public async Task<string?> GetTBIncPer(int pintTBIncCode)
		{
			return await _commonMethods.SearchTextAsync<string>("TBIncMast", "TBIN_Code", pintTBIncCode.ToString(), "Per");
		}
		public async Task<List<TBIncMastDto>> GetAllTBIncMast()
		{
			return await _dRepository.GetAll<TBIncMastDto>("SP_MastTBIncMastFill");
		}
		public async Task<int> AddTBIncMast(TBIncMastDto tBIncMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_TBIncMastSave", tBIncMast);
		}
		public async Task<int> UpdateTBIncMast(TBIncMastDto tBIncMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_TBIncMastSave", tBIncMast);
		}
		public async Task<int> DeleteTBIncMast(short TBIN_Code)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_UtilTBIncMastDel", new { TBIN_Code });
		}
	}
}
