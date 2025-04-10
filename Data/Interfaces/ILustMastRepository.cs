using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Interfaces
{
	public interface ILustMastRepository
	{
		Task<List<LustMastDto>> GetAllLustMast();
		Task<int> AddLustMast(LustMastDto lustMast);
		Task<int> UpdateLustMast(LustMastDto lustMast);
		Task<int> DeleteLustMast(short LU_Code);
		Task<string?> GetLustPer(int pintLUCode);
	}
}
