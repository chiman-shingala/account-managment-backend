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
	public class TIncMastService : ITIncMastService
	{
		private readonly ITIncMastRepository _tIncMast;

		public TIncMastService(ITIncMastRepository tIncMast)
		{
			_tIncMast = tIncMast;
		}
		public async Task<List<TIncMastDto>> GetAllTIncMast()
		{
			return await _tIncMast.GetAllTIncMast();
		}
		public async Task<int> AddTIncMast(TIncMastDto incMast)
		{
			return await _tIncMast.AddTIncMast(incMast);
		}
		public async Task<int> UpdateTIncMast(TIncMastDto incMast)
		{
			return await _tIncMast.UpdateTIncMast(incMast);
		}
		public async Task<int> DeleteTIncMast(short TinCode)
		{
			return await _tIncMast.DeleteTIncMast(TinCode);
		}
	}
}
