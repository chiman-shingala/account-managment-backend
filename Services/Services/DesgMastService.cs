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
	public class DesgMastService : IDesgMastService
	{
		private readonly IDesgMastRepository _desgMast;

		public DesgMastService(IDesgMastRepository desgMast)
		{
			_desgMast = desgMast;
		}
		public async Task<List<DesgMastDto>> GetAllDesgMast()
		{
			return await _desgMast.GetAllDesgMast();
		}
		public async Task<int> AddDesgMast(DesgMastDto desgMast)
		{
			return await _desgMast.AddDesgMast(desgMast);
		}
		public async Task<int> UpdateDesgMast(DesgMastDto desgMast)
		{
			return await _desgMast.UpdateDesgMast(desgMast);
		}
		public async Task<int> DeleteDesgMast(string D_Code)
		{
			return await _desgMast.DeleteDesgMast(D_Code);
		}
	}
}
