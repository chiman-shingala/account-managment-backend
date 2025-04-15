using Acc.Data.Interfaces;
using Acc.Services.Interfaces.Price_Para;
using Acc.Shared.Dtos;
using Data.Models;


namespace Acc.Services.Services.Price_Para
{
	public class BrnMastService : IBrnMastService
	{
		private readonly IBrnMastRepository _brnMastRepository;

		public BrnMastService(IBrnMastRepository brnMastRepository)
		{
			_brnMastRepository = brnMastRepository;
		}
		public async Task<List<BrnMastDto>> GetAllBrnMast()
		{
			return await _brnMastRepository.GetAllBrnMast();
		}
		public async Task<int> AddBrnMast(BrnMastDto brnMast)
		{
			return await _brnMastRepository.AddBrnMast(brnMast);
		}
		public async Task<int> UpdateBrnMast(BrnMastDto brnMast)
		{
			return await _brnMastRepository.UpdateBrnMast(brnMast);
		}
		public async Task<int> DeleteBrnMast(short BRN_Code)
		{
			return await _brnMastRepository.DeleteBrnMast(BRN_Code);
		}
	}
}
