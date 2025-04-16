using Acc.Data.Interfaces;
using Acc.Services.Interfaces.Price_Para;
using Acc.Shared.Dtos;

namespace Acc.Services.Services.Price_Para
{
	public class SIncMastService : ISIncMastService
	{
		private readonly ISIncMastRepository _sIncMast;

		public SIncMastService(ISIncMastRepository sIncMast)
		{
			_sIncMast = sIncMast;
		}
		public async Task<List<SIncMastDto>> GetAllSIncMast()
		{
			return await _sIncMast.GetAllSIncMast();
		}
		public async Task<int> AddSIncMast(SIncMastDto sbincMast)
		{
			return await _sIncMast.AddSIncMast(sbincMast);
		}
		public async Task<int> UpdateSIncMast(SIncMastDto sbincMast)
		{
			return await _sIncMast.UpdateSIncMast(sbincMast);
		}
		public async Task<int> DeleteSIncMast(short SIN_Code)
		{
			return await _sIncMast.DeleteSIncMast(SIN_Code);
		}
	}
}
