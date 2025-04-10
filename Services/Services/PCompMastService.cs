using Acc.Data.Interfaces.IMaster;
using Acc.Services.Interfaces;
using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Services
{
	public class PCompMastService : IPCompMastService
	{
		private readonly IPCompMastRepository _pCompMast;

		public PCompMastService(IPCompMastRepository pCompMast)
		{
			_pCompMast = pCompMast;
		}
		//public async Task<List<ParMastDto>> GetAllParMast(ParMastFillDto parMastFill)
		//{
		//	return await _parMast.GetAllParMast(parMastFill);
		//}
		public async Task<int> AddPCompMast(PCompMastDto pCompMast)
		{
			return await _pCompMast.AddPCompMast(pCompMast);
		}
		public async Task<int> UpdatePCompMast(PCompMastDto pCompMast)
		{
			return await _pCompMast.UpdatePCompMast(pCompMast);
		}
		public async Task<int> DeletePCompMast(string P_Code, int Acyear, string Comp_Code)
		{
			return await _pCompMast.DeletePCompMast(P_Code, Acyear, Comp_Code);
		}
	}
}
