using Acc.Data.Interfaces;
using Acc.Data.Repository.Interface;
using Acc.Shared.Dtos;
using System.Diagnostics.CodeAnalysis;

namespace Acc.Data.Repositories
{
	public class LustMastRepository : ILustMastRepository
	{
		private readonly IDRepository _dRepository;

		public LustMastRepository(IDRepository dRepository)
		{
			_dRepository = dRepository;
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
	}
}
