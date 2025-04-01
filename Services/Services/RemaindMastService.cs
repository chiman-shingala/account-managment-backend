using Acc.Data.Interfaces;
using Acc.Services.Interfaces;
using Acc.Shared.Dtos;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Services
{
	public class RemaindMastService : IRemaindMastService
	{
		private readonly IRemaindMastRepository _remaindMast;

		public RemaindMastService(IRemaindMastRepository remaindMast)
		{
			_remaindMast = remaindMast;
		}
		public async Task<List<RemaindMastDto>> GetAllRemaindMast()
		{
			return await _remaindMast.GetAllRemaindMast();	
		}
		public async Task<int> AddRemaindMast(RemaindMastDto remaindMast)
		{
			return await _remaindMast.AddRemaindMast(remaindMast);
		}
		public async Task<int> UpdateRemaindMast(RemaindMastDto remaindMast)
		{
			return await _remaindMast.UpdateRemaindMast(remaindMast);
		}
		public async Task<int> DeleteRemaindMast(string Rem_Code)
		{
			return await _remaindMast.DeleteRemaindMast(Rem_Code);
		}
	}
}
