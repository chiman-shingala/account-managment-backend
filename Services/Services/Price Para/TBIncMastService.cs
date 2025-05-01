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
	public class TBIncMastService : ITBIncMastService
	{
		private readonly ITBIncMastRepository _tBIncMast;

		public TBIncMastService(ITBIncMastRepository tBIncMast)
		{
			_tBIncMast = tBIncMast;
		}
		public async Task<List<TBIncMastDto>> GetAllTBIncMast()
		{
			return await _tBIncMast.GetAllTBIncMast();
		}
		public async Task<int> AddTBIncMast(TBIncMastDto tBIncMast)
		{
			return await _tBIncMast.AddTBIncMast(tBIncMast);
		}
		public async Task<int> UpdateTBIncMast(TBIncMastDto tBIncMast)
		{
			return await _tBIncMast.UpdateTBIncMast(tBIncMast);
		}
		public async Task<int> DeleteTBIncMast(short TBIN_Code)
		{
			return await _tBIncMast.DeleteTBIncMast(TBIN_Code);
		}
	}
}
