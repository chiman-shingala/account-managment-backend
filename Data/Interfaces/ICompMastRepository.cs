using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Interfaces
{
	public interface ICompMastRepository
	{
		Task<List<CompMastDto>> GetAllCompany(string UserId);
		Task<int> AddCompany(CompMastDto compMast);
		Task<int> UpdateCompany(CompMastDto compMast);
		Task<int> DeleteColour(string Comp_Code);
	}
}
