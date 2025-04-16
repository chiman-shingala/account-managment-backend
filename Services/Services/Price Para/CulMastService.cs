using Acc.Data.Interfaces.IMaster;
using Acc.Services.Interfaces.Price_Para;
using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Services.Price_Para
{
	public class CulMastService : ICulMastService
	{
		private readonly ICulMastRepository _culMast;

		public CulMastService(ICulMastRepository culMast)
		{
			_culMast = culMast;
		}
		public async Task<List<CulMastDto>> GetAllCulMast()
		{
			return await _culMast.GetAllCulMast();
		}
		public async Task<int> AddCulMast(CulMastDto culMast)
		{
			return await _culMast.AddCulMast(culMast);
		}
		public async Task<int> UpdateCulMast(CulMastDto culMast)
		{
			return await _culMast.UpdateCulMast(culMast);
		}
		public async Task<int> DeleteCulMast(short CU_Code)
		{
			return await _culMast.DeleteCulMast(CU_Code);
		}
	}
}
