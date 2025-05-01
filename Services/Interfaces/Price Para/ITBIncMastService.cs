using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Interfaces.Price_Para
{
	public interface ITBIncMastService
	{
		Task<List<TBIncMastDto>> GetAllTBIncMast();
		Task<int> AddTBIncMast(TBIncMastDto tBIncMast);
		Task<int> UpdateTBIncMast(TBIncMastDto tBIncMast);
		Task<int> DeleteTBIncMast(short TBIN_Code);
	}
}
