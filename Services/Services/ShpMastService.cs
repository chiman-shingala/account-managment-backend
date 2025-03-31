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
	public class ShpMastService : IShpMastService
	{
		private readonly IShpMastRepository _shpMast;

		public ShpMastService(IShpMastRepository shpMast)
		{
			_shpMast = shpMast;
		}
		public async Task<List<ShpMastDto>> GetAllShape()
		{
			return await _shpMast.GetAllShape();
		}
		public async Task<int> AddShape(ShpMastDto shpMast)
		{
			return await _shpMast.AddShape(shpMast);
		}
		public async Task<int> UpdateShape(ShpMastDto shpMast)
		{
			return await _shpMast.UpdateShape(shpMast);
		}
		public async Task<int> DeleteShape(string S_Code)
		{
			return await _shpMast.DeletePurity(S_Code);
		}
	}
}
