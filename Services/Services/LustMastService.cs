using Acc.Data.Interfaces;
using Acc.Services.Interfaces;
using Acc.Shared.Dtos;

namespace Acc.Services.Services
{
	public class LustMastService : ILustMastService
	{
		private readonly ILustMastRepository _lustMast;

		public LustMastService(ILustMastRepository lustMast)
		{
			_lustMast = lustMast;
		}
		public async Task<List<LustMastDto>> GetAllLustMast()
		{
			return await _lustMast.GetAllLustMast();
		}
		public async Task<int> AddLustMast(LustMastDto lustMast)
		{
			return await _lustMast.AddLustMast(lustMast);
		}
		public async Task<int> UpdateLustMast(LustMastDto lustMast)
		{
			return await _lustMast.UpdateLustMast(lustMast);
		}
		public async Task<int> DeleteLustMast(short LU_Code)
		{
			return await _lustMast.DeleteLustMast(LU_Code);
		}
	}
}
