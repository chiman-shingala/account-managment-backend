using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Interfaces.IUtility
{
	public interface ISalEncRateRepository
	{
		Task<List<SalEncRateDto>> GetAllSalEncRate(string Comp_Code);
		Task<int> AddSalEncRate(SalEncRateDto salEncRateDto);
		Task<int> UpdateSalEncRate(SalEncRateDto salEncRateDto);
		Task<int> DeleteSalEncRate(string EncVal);
	}
}
