using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Interfaces.IMaster
{
	public interface IBrokenMastRepository
	{
		Task<List<BrokenMastDto>> GetAllBrokenMast();
		Task<int> AddBrokenMast(BrokenMastDto brokenMast);
		Task<int> UpdateBrokenMast(BrokenMastDto brokenMast);
		Task<int> DeleteBrokenMast(string BRO_Code);

	}
}
