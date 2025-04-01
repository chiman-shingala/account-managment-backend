using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Interfaces
{
	public interface IBrokenMastService
	{
		Task<List<BrokenMastDto>> GetAllBrokenMast();
		Task<int> AddBroken(BrokenMastDto brokenMast);
		Task<int> UpdateBroken(BrokenMastDto brokenMast);
		Task<int> DeleteBroken(string BRO_Code);
	}
}
