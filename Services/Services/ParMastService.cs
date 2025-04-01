using Acc.Data.Interfaces;
using Acc.Services.Interfaces;
using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Services
{
	public class ParMastService : IParMastService
	{
		private readonly IParMastRepository _parMast;

		public ParMastService(IParMastRepository parMast)
		{
			_parMast = parMast;
		}
		public async Task<List<ParMastDto>> GetAllParMast(ParMastFillDto parMastFill)
		{
			return await _parMast.GetAllParMast(parMastFill);
		}
		public async Task<int> AddParMast(ParMastDto parMast)
		{
			return await _parMast.AddParMast(parMast);
		}
		public async Task<int> UpdateParMast(ParMastDto parMast)
		{
			return await _parMast.UpdateParMast(parMast);
		}
		public async Task<int> DeleteParMast(string P_Code, int Acyear, string Comp_Code)
		{
			return await _parMast.DeleteParMast(P_Code,Acyear,Comp_Code);
		}
	}
}
