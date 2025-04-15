using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Interfaces.Price_Para
{
	public interface IBrnMastService
	{
		Task<List<BrnMastDto>> GetAllBrnMast();
		Task<int> AddBrnMast(BrnMastDto brnMast);
		Task<int> UpdateBrnMast(BrnMastDto brnMast);
		Task<int> DeleteBrnMast(short BRN_Code);
	}
}
