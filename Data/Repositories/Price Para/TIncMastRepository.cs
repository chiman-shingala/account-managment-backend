using Acc.Data.Interfaces;
using Acc.Data.Repository.Interface;
using Acc.Shared.Common;
using Acc.Shared.Dtos;
namespace Acc.Data.Repositories
{
	public class TIncMastRepository : ITIncMastRepository
	{
		private readonly CommonMethods _commonMethods;
		private readonly IDRepository _dRepository;

		public TIncMastRepository(CommonMethods commonMethods,IDRepository dRepository)
		{
			_commonMethods = commonMethods;
			_dRepository = dRepository;
		}
		public async Task<string?> GetTIncPer(int pintTIncCode)
		{
			return await _commonMethods.SearchTextAsync<string>("TIncMast", "TIN_Code", pintTIncCode.ToString(), "Per");
		}		
		public async Task<List<TIncMastDto>> GetAllTIncMast()
		{
			return await _dRepository.GetAll<TIncMastDto>("SP_MastTIncMastFill");
		}
		public async Task<int> AddTIncMast(TIncMastDto incMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_TIncMastSave", incMast);
		}
		public async Task<int> UpdateTIncMast(TIncMastDto incMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_TIncMastSave", incMast);
		}
		public async Task<int> DeleteTIncMast(short TIN_Code)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_UtilTIncMastDel", new { TIN_Code });
		}
	}
}
