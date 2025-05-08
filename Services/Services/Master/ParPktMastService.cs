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
	public class ParPktMastService : IParPktMastService
	{
		private readonly IParPktMastRepository _parPktMast;

		public ParPktMastService(IParPktMastRepository parPktMast)
		{
			_parPktMast = parPktMast;
		}
		public async Task<List<ParPktMastDto>> GetAllParPktMast(string Comp_Code)
		{
			return await _parPktMast.GetAllParPktMast(Comp_Code);
		}
		public async Task<int> AddParPktMast(ParPktMastDto parPktMast)
		{
			return await _parPktMast.AddParPktMast(parPktMast);
		}
		public async Task<int> UpdateParPktMast(ParPktMastDto parPktMast)
		{
			return await _parPktMast.UpdateParPktMast(parPktMast);
		}
		public async Task<int> DeleteParPktMast(string ParPId,string Comp_Code)
		{
			return await _parPktMast.DeleteParPktMast(ParPId, Comp_Code);
		}
	}
}
