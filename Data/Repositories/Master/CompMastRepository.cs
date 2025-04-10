using Acc.Data.Interfaces.IMaster;
using Acc.Data.Repository.Interface;
using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Repositories.Master
{
	public class CompMastRepository : ICompMastRepository
	{
		private readonly IDRepository _dRepository;

		public CompMastRepository(IDRepository dRepository)
		{
			_dRepository = dRepository;
		}
		public async Task<List<CompMastDto>> GetAllCompany(string UserId)
		{
			return await _dRepository.GetAll<CompMastDto>("SP_MastComMastFill", new { UserId });
		}
		public async Task<int> AddCompany(CompMastDto compMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_CompMastSave", compMast);
		}
		public async Task<int> UpdateCompany(CompMastDto compMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_CompMastSave", compMast);
		}
		public async Task<int> DeleteCompany(string Comp_Code)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_UtilCompMastCompDel", new { Comp_Code });
		}
	}
}
