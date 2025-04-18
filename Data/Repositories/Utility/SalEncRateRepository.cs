using Acc.Data.Interfaces.IUtility;
using Acc.Data.Repository.Interface;
using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Repositories.Utility
{
	public class SalEncRateRepository : ISalEncRateRepository
	{
		private readonly IDRepository _dRepository;

		public SalEncRateRepository(IDRepository dRepository)
		{
			_dRepository = dRepository;
		}
		public async Task<List<SalEncRateDto>> GetAllSalEncRate(string Comp_Code)
		{
			return await _dRepository.GetAll<SalEncRateDto>("usp_SalesEncRateDef",new { Comp_Code });
		}
		public async Task<int> AddSalEncRate(SalEncRateDto salEncRateDto)
		{
			return await _dRepository.ExecuteAsyncQuery("usp_SalesEncRateSave", salEncRateDto);
		}
		public async Task<int> UpdateSalEncRate(SalEncRateDto salEncRateDto)
		{
			return await _dRepository.ExecuteAsyncQuery("usp_SalesEncRateSave", salEncRateDto);
		}
		public async Task<int> DeleteSalEncRate(string EncVal)
		{
			return await _dRepository.ExecuteAsyncQuery("usp_SalesEncRateSave", new { EncVal });
		}
	}
}
