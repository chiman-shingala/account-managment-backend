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
	public class TOIncMastService : ITOIncMastService
	{
		private readonly ITOIncMastRepository _tOIncMast;

		public TOIncMastService(ITOIncMastRepository tOIncMast)
		{
			_tOIncMast = tOIncMast;
		}
		public async Task<List<TOIncMastDto>> GetAllTOIncMast()
		{
			return await _tOIncMast.GetAllTOIncMast();
		}
		public async Task<int> AddTOIncMast(TOIncMastDto tOIncMast)
		{
			return await _tOIncMast.AddTOIncMast(tOIncMast);
		}
		public async Task<int> UpdateTOIncMast(TOIncMastDto tOIncMast)
		{
			return await _tOIncMast.UpdateTOIncMast(tOIncMast);
		}
		public async Task<int> DeleteTIncMast(short TOIN_Code)
		{
			return await _tOIncMast.DeleteTOIncMast(TOIN_Code);
		}
	}
}
