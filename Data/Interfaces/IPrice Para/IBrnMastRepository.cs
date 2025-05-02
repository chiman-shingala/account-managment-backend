using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Interfaces
{
	public interface IBrnMastRepository
	{
		Task<string?> GetBrnPer(int pintBRNCode);
		Task<List<BrnMastDto>> GetAllBrnMast();
		Task<int> AddBrnMast(BrnMastDto brnMast);
		Task<int> UpdateBrnMast(BrnMastDto brnMast);
		Task<int> DeleteBrnMast(short BRN_Code);

	}
}
