using Acc.Data.Interfaces.IMaster;
using Acc.Services.Interfaces.Master;
using Acc.Shared.Dtos;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Services.Master
{
	public class AGrpMastService : IAGrpMastService
	{
		private readonly IAGrpMastRepository _aGrpMast;

		public AGrpMastService(IAGrpMastRepository aGrpMast)
		{
			_aGrpMast = aGrpMast;
		}
		public async Task<List<AGrpMastDto>> GetAllAGrp()
		{
			return await _aGrpMast.GetAllAGrp();
		}
		public async Task<int> NewIdAGrpMast()
		{
			return await _aGrpMast.NewIdAGrpMast();
		}
		public async Task<int> AddAGrp(AGrpMastDto aGrpMast)
		{
			return await _aGrpMast.AddAGrp(aGrpMast);
		}
		public async Task<int> UpdateAGrp(AGrpMastDto aGrpMast)
		{
			return await _aGrpMast.UpdateAGrp(aGrpMast);
		}
		public async Task<int> DeleteAGrp(int AGR_Code)
		{
			return await _aGrpMast.DeleteAGrp(AGR_Code);
		}
		public async Task<List<GRTypeDto>> GetGrpType()
		{
			return await _aGrpMast.GetGrpType();
		}
	}
}
