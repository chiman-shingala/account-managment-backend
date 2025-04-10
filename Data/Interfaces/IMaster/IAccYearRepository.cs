using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Interfaces.IMaster
{
	public interface IAccYearRepository
	{
		Task<List<AccYearDto>> GetAllAccYear(string Comp_Code);
		Task<int> AddAccYear(AccYearDto accYearDto);
		Task<int> UpdateAccYear(AccYearDto accYearDto);
		Task<int> DeleteAccYear(string Comp_Code);
	}
}
