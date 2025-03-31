using Acc.Data.Interfaces;
using Acc.Data.Repositories;
using Acc.Services.Interfaces;
using Acc.Shared.Dtos;
using Microsoft.AspNetCore.Cors.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Services
{
	public class ColMastService : IColMastService
	{
		private readonly IColMastRepository _colMast;

		public ColMastService(IColMastRepository colMast)
		{
			_colMast = colMast;
		}
		public async Task<List<ColMastDto>> GetAllColours()
		{
			return await _colMast.GetAllColours();
		}
		public async Task<int> AddColour(ColMastDto colMast)
		{
			return await _colMast.AddColour(colMast);
		}
		public async Task<int> UpdateColour(ColMastDto colMast)
		{
			return await _colMast.UpdateColour(colMast);
		}
		public async Task<int> DeleteColour(short C_Code)
		{
			return await _colMast.DeleteColour(C_Code);
		}
	}
}
