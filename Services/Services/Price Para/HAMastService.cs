using Acc.Data.Interfaces;
using Acc.Services.Interfaces.Price_Para;
using Acc.Shared.Dtos;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Services.Price_Para
{
	public class HAMastService : IHAMastService
	{
		private readonly IHAMastRepository _hAMast;

		public HAMastService(IHAMastRepository hAMast)
		{
			_hAMast = hAMast;
		}
		public async Task<List<HAMastDto>> GetAllHAMast()
		{
			return await _hAMast.GetAllHAMast();
		}
		public async Task<int> AddHAMast(HAMastDto HAMast)
		{
			return await _hAMast.AddHAMast(HAMast);
		}
		public async Task<int> UpdateHAMast(HAMastDto HAMast)
		{
			return await _hAMast.UpdateHAMast(HAMast);
		}
		public async Task<int> DeleteHAMast(short HA_Code)
		{
			return await _hAMast.DeleteHAMast(HA_Code);
		}
	}
}
