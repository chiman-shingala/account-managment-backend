using Acc.Data.Interfaces;
using Acc.Data.Repository.Interface;
using Acc.Shared.Common;
using Acc.Shared.Dtos;
using System.Diagnostics.CodeAnalysis;

namespace Acc.Data.Repositories
{
	public class LustMastRepository : ILustMastRepository
	{
		private readonly IDRepository _dRepository;
		private readonly CommonMethods _commonMethods;

		public LustMastRepository(IDRepository dRepository,CommonMethods commonMethods)
		{
			_dRepository = dRepository;
			_commonMethods = commonMethods;
		}
		public async Task<List<LustMastDto>> GetAllLustMast()
		{
			return await _dRepository.GetAll<LustMastDto>("SP_MastLustMastFill");
		}
		public async Task<int> AddLustMast(LustMastDto lustMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_LustMastSave", lustMast);
		}
		public async Task<int> UpdateLustMast(LustMastDto lustMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_LustMastSave", lustMast);
		}
		public async Task<int> DeleteLustMast(short LU_Code)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_UtilLustMastDel", new { LU_Code });
		}
		public async Task<string?> GetLustPer(int pintLUCode)
		{
			return await _commonMethods.SearchTextAsync<string>("LustMast", "LU_Code", pintLUCode.ToString(), "Per");
		}
	}
}
