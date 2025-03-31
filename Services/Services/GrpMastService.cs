using Acc.Data.Interfaces;
using Acc.Data.Repositories;
using Acc.Services.Interfaces;
using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Services
{
	public class GrpMastService : IGrpMastService
	{
		private readonly IGrpMastRepository _grpMast;

		public GrpMastService(IGrpMastRepository grpMast)
		{
			_grpMast = grpMast;
		}
		public async Task<List<GrpMastDto>> GetAllGrp()
		{
			return await _grpMast.GetAllGroup();
		}
		public async Task<int> AddGrp(GrpMastDto grpMast)
		{
			return await _grpMast.AddGroup(grpMast);
		}
		public async Task<int> UpdateGrp(GrpMastDto grpMast)
		{
			return await _grpMast.UpdateGroup(grpMast);
		}
		public async Task<int> DeleteGrp(string GR_Code)
		{
			return await _grpMast.DeleteGroup(GR_Code);
		}
	}
}
