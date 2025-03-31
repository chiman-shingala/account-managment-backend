using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Interfaces
{
	public interface IAccYearService
	{
		Task<List<AccYearDto>> GetAllAccYear(string Comp_Code);
		Task<int> AddAccYear(AccYearDto accYear);
		Task<int> UpdateAccYear(AccYearDto accYear);
		Task<int> DeleteAccYear(string Comp_Code);
	}
}
