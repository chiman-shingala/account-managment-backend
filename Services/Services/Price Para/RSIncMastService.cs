using Acc.Data.Interfaces;
using Acc.Services.Interfaces.Price_Para;
using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Services.Price_Para
{
	public class RSIncMastService : IRSIncMastService
	{
		private readonly IRSIncMastRepository _rSIncMast;

		public RSIncMastService(IRSIncMastRepository rSIncMast)
		{
			_rSIncMast = rSIncMast;
		}
		public async Task<List<RsincMastDto>> GetAllRSIncMast()
		{
			return await _rSIncMast.GetAllRSIncMast();
		}
		public async Task<int> AddRSIncMast(RsincMastDto rsincMast)
		{
			return await _rSIncMast.AddRSIncMast(rsincMast);
		}
		public async Task<int> UpdateRSIncMast(RsincMastDto rsincMast)
		{
			return await _rSIncMast.UpdateRSIncMast(rsincMast);
		}
		public async Task<int> DeleteRSIncMast(short RSIN_Code)
		{
			return await _rSIncMast.DeleteRSIncMast(RSIN_Code);
		}
	}
}
