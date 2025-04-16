using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Interfaces.Price_Para
{
	public interface ICulMastService
	{
		Task<List<CulMastDto>> GetAllCulMast();
		Task<int> AddCulMast(CulMastDto culMast);
		Task<int> UpdateCulMast(CulMastDto culMast);
		Task<int> DeleteCulMast(short CU_Code);
	}
}
