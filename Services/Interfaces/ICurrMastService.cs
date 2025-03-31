using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Interfaces
{
	public interface ICurrMastService
	{
		Task<List<CurrMastDto>> GetAllCurrent();
		Task<int> AddCurrent(CurrMastDto currMast);
		Task<int> UpdateCurrent(CurrMastDto currMast);
		Task<int> DeleteCurrent(string CnCy);
	}
}
