using Acc.Data.Interfaces;
using Acc.Services.Interfaces.Master;
using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Services.Master
{
	public class FloMastService : IFloMastService
	{
		private readonly IFloMastRepository _floMast;

		public FloMastService(IFloMastRepository floMast)
		{
			_floMast = floMast;
		}
		public async Task<List<FloMastDto>> GetAllFloMast()
		{
			return await _floMast.GetAllFloMast();
		}
		public async Task<int> AddFloMast(FloMastDto floMastDto)
		{
			return await _floMast.AddFloMast(floMastDto);
		}
		public async Task<int> UpdateFloMast(FloMastDto floMastDto)
		{
			return await _floMast.UpdateFloMast(floMastDto);
		}
		public async Task<int> DeleteFloMast(string FL_Code)
		{
			return await _floMast.DeleteDesgMast(FL_Code);
		}
	}
}
