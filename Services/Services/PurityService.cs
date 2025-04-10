using Acc.Data.Interfaces.IMaster;
using Acc.Data.Repositories;
using Acc.Services.Interfaces;
using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Services
{
	public class PurityService : IPurityService
	{
		private readonly IPurityMastRepository _purityMast;

		public PurityService(IPurityMastRepository purityMast)
		{
			_purityMast = purityMast;
		}		
		public async Task<List<QuaMastDto>> GetAllPurity()
		{
			return await _purityMast.GetAllPurity();
		}
		public async Task<int> AddPurity(QuaMastDto quaMast)
		{
			return await _purityMast.AddPurity(quaMast);
		}
		public async Task<int> UpdatePurity(QuaMastDto quaMast)
		{
			return await _purityMast.UpdatePurity(quaMast);
		}
		public async Task<int> DeletePurity(short Q_Code)
		{
			return await _purityMast.DeletePurity(Q_Code);
		}
	}
}
