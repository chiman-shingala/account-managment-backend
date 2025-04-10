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
	public class BrokenMastService : IBrokenMastService
	{
		private readonly IBrokenMastRepository _brokenMast;

		public BrokenMastService(IBrokenMastRepository brokenMast)
		{
			_brokenMast = brokenMast;
		}
		public async Task<List<BrokenMastDto>> GetAllBrokenMast()
		{
			return await _brokenMast.GetAllBrokenMast();
		}
		public async Task<int> AddBroken(BrokenMastDto brokenMast)
		{
			return await _brokenMast.AddBrokenMast(brokenMast);
		}
		public async Task<int> UpdateBroken(BrokenMastDto brokenMast)
		{
			return await _brokenMast.UpdateBrokenMast(brokenMast);
		}
		public async Task<int> DeleteBroken(string BRO_Code)
		{
			return await _brokenMast.DeleteBrokenMast(BRO_Code);
		}
	}
}
