using Acc.Data.Interfaces;
using Acc.Services.Interfaces.Price_Para;
using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Services.Price_Para
{
	public class SBIncMastService : ISBIncMastService
	{
		private readonly ISBIncMastRepository _sBIncMast;

		public SBIncMastService(ISBIncMastRepository sBIncMast)
		{
			_sBIncMast = sBIncMast;
		}
		public async Task<List<SbincMastDto>> GetAllSBIncMast()
		{
			return await _sBIncMast.GetAllSBIncMast();
		}
		public async Task<int> AddSBIncMast(SbincMastDto sbincMast)
		{
			return await _sBIncMast.AddSBIncMast(sbincMast);
		}
		public async Task<int> UpdateSBIncMast(SbincMastDto sbincMast)
		{
			return await _sBIncMast.UpdateSBIncMast(sbincMast);
		}
		public async Task<int> DeleteSIncMast(short SBIN_Code)
		{
			return await _sBIncMast.DeleteSBIncMast(SBIN_Code);
		}
	}
}
