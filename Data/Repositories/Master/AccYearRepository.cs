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
	public class AccYearRepository : IAccYearRepository
	{
		private readonly IDRepository _dRepository;

		public AccYearRepository(IDRepository dRepository)
		{
			_dRepository = dRepository;
		}
		public async Task<List<AccYearDto>> GetAllAccYear(string Comp_Code)
		{
			return await _dRepository.GetAll<AccYearDto>("SP_MastAccYearFill",new { Comp_Code});
		}
		public async Task<int> AddAccYear(AccYearDto accYearDto)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_UtilAccYearCreateAccYear", accYearDto);
		}
		public async Task<int> UpdateAccYear(AccYearDto accYearDto)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_UtilAccYearUpdateAccYear", accYearDto);
		}
		public async Task<int> DeleteAccYear(string Comp_Code)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_UtilAccYearDel", new { Comp_Code });
		}
	}
}
