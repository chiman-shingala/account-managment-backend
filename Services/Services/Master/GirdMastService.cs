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
	public class GirdMastService : IGirdMastService	
	{
		private readonly IGirdMastRepository _girdMast;

		public GirdMastService(IGirdMastRepository girdMast)
		{
			_girdMast = girdMast;
		}
		public async Task<List<GirdMastDto>> GetAllGridMast()
		{
			return await _girdMast.GetAllGridMast();
		}
		public async Task<int> AddGridMast(GirdMastDto girdMast)
		{
			return await _girdMast.AddGridMast(girdMast);
		}
		public async Task<int> UpdateGridMast(GirdMastDto girdMast)
		{
			return await _girdMast.UpdateGridMast(girdMast);
		}
		public async Task<int> DeleteGridMast(string Gr_Code)
		{
			return await _girdMast.DeleteGridMast(Gr_Code);
		}
	}
}
