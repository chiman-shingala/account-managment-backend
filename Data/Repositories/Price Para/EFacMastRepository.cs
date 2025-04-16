using Acc.Data.Interfaces;
using Acc.Data.Repository.Interface;
using Acc.Shared.Common;
using Acc.Shared.Dtos;


namespace Acc.Data.Repositories
{
	public class EFacMastRepository : IEFacMastRepository
	{
		private readonly CommonMethods _commonMethods;
		private readonly IDRepository _dRepository;

		public EFacMastRepository(CommonMethods commonMethods,IDRepository dRepository)
		{
			_commonMethods = commonMethods;
			_dRepository = dRepository;
		}
		public async Task<string?> GetEFacPer(int pintEFCode)
		{
			return await _commonMethods.SearchTextAsync<string>("EFacMast", "EF_Code", pintEFCode.ToString(), "Per");
		}
		public async Task<List<EfacMastDto>> GetAllEFacMast()
		{
			return await _dRepository.GetAll<EfacMastDto>("SP_MastEFacMastFill");
		}
		public async Task<int> AddEFacMast(EfacMastDto efacMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_EFactMastSave", efacMast);
		}
		public async Task<int> UpdateEFacMast(EfacMastDto efacMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_EFactMastSave", efacMast);
		}
		public async Task<int> DeleteEFacMast(short EF_Code)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_UtilEFacMastDel", new { EF_Code });
		}
	}
}
