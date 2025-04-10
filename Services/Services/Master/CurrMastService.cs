using Acc.Data.Interfaces.IMaster;
using Acc.Services.Interfaces.Master;
using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Services.Master
{
	public class CurrMastService : ICurrMastService
	{
		private readonly ICurrMastRepository _currMast;

		public CurrMastService(ICurrMastRepository currMast)
		{
			_currMast = currMast;
		}
		public async Task<List<CurrMastDto>> GetAllCurrent()
		{
			return await _currMast.GetAllCurrent();
		}
		public async Task<int> AddCurrent(CurrMastDto currMast)
		{
			return await _currMast.AddCurrent(currMast);
		}
		public async Task<int> UpdateCurrent(CurrMastDto currMast)
		{
			return await _currMast.UpdateCurrent(currMast);
		}
		public async Task<int> DeleteCurrent(string CnCy)
		{
			return await _currMast.DeleteCurrent(CnCy);
		}
	}
}
