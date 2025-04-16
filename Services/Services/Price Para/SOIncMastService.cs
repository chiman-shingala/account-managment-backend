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
	public class SOIncMastService : ISOIncMastService
	{
		private readonly ISOIncMastRepository _sOIncMast;

		public SOIncMastService(ISOIncMastRepository sOIncMast)
		{
			_sOIncMast = sOIncMast;
		}
		public async Task<List<SoincMastDto>> GetAllSOIncMast()
		{
			return await _sOIncMast.GetAllSOIncMast();
		}
		public async Task<int> AddSOIncMast(SoincMastDto soincMast)
		{
			return await _sOIncMast.AddSOIncMast(soincMast);
		}
		public async Task<int> UpdateSOIncMast(SoincMastDto soincMast)
		{
			return await _sOIncMast.UpdateSOIncMast(soincMast);
		}
		public async Task<int> DeleteSOIncMast(short SOIN_Code)
		{
			return await _sOIncMast.DeleteSOIncMast(SOIN_Code);
		}
	}	
}
