using Acc.Data.Interfaces.IUtility;
using Acc.Services.Interfaces.Utility;
using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Services.Utility
{
	public class SalEncRateService : ISalEncRateService
	{
		private readonly ISalEncRateRepository _salEncRateRepository;
		public SalEncRateService(ISalEncRateRepository salEncRateRepository)
		{
			_salEncRateRepository = salEncRateRepository;
		}
		public async Task<List<SalEncRateDto>> GetAllSalEncRate(string Comp_Code)
		{
			return await _salEncRateRepository.GetAllSalEncRate(Comp_Code);
		}
		public async Task<int> AddSalEncRate(SalEncRateDto salEncRateDto)
		{
			return await _salEncRateRepository.AddSalEncRate(salEncRateDto);
		}
		public async Task<int> UpdateSalEncRate(SalEncRateDto salEncRateDto)
		{
			return await _salEncRateRepository.UpdateSalEncRate(salEncRateDto);
		}
		public async Task<int> DeleteSalEncRate(string EncVal)
		{
			return await _salEncRateRepository.DeleteSalEncRate(EncVal);
		}
	}	
}
