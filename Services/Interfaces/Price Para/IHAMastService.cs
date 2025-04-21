using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Interfaces.Price_Para
{
	public interface IHAMastService
	{
		Task<List<HAMastDto>> GetAllHAMast();
		Task<int> AddHAMast(HAMastDto HAMast);
		Task<int> UpdateHAMast(HAMastDto HAMast);
		Task<int> DeleteHAMast(short EF_Code);
	}
}
