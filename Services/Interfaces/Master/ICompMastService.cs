using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Interfaces.Master
{
	public interface ICompMastService
	{
		Task<List<CompMastDto>> GetAllCompany(string UserId);
		Task<int> AddCompany(CompMastDto compMast);
		Task<int> UpdateCompany(CompMastDto compMast);
		Task<int> DeleteCompany(string Comp_Code);
	}
}
