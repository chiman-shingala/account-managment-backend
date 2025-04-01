using Acc.Data.Interfaces;
using Acc.Services.Interfaces;
using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Services
{
	public class CompMastService : ICompMastService
	{
		private readonly ICompMastRepository _compMast;

		public CompMastService(ICompMastRepository compMast)
		{
			_compMast = compMast;
		}
		public async Task<List<CompMastDto>> GetAllCompany(string Comp_Code)
		{
			return await _compMast.GetAllCompany(Comp_Code);
		}
		public async Task<int> AddCompany(CompMastDto compMast)
		{
			return await _compMast.AddCompany(compMast);
		}
		public async Task<int> UpdateCompany(CompMastDto compMast)
		{
			return await _compMast.UpdateCompany(compMast);
		}
		public async Task<int> DeleteCompany(string Comp_Code)
		{
			return await _compMast.DeleteCompany(Comp_Code);
		}
	}
}
