using Acc.Data.Interfaces.IMaster;
using Acc.Services.Interfaces.Master;
using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Services.Master
{
	public class AccYearService : IAccYearService
	{
		private readonly IAccYearRepository _accYear;

		public AccYearService(IAccYearRepository accYear)
		{
			_accYear = accYear;
		}
		public async Task<List<AccYearDto>> GetAllAccYear(string Comp_Code)
		{
			return await _accYear.GetAllAccYear(Comp_Code);
		}
		public async Task<int> AddAccYear(AccYearDto accYear)
		{
			return await _accYear.AddAccYear(accYear);
		}
		public async Task<int> UpdateAccYear(AccYearDto accYear)
		{
			return await _accYear.UpdateAccYear(accYear);
		}
		public async Task<int> DeleteAccYear(string Comp_Code, int AcYear)
		{
			return await _accYear.DeleteAccYear(Comp_Code, AcYear);
		}
	}
}
