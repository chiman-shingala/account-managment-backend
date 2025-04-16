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
	public class EFacMastService : IEFacMastService
	{
		private readonly IEFacMastRepository _eFacMast;

		public EFacMastService(IEFacMastRepository eFacMast)
		{
			_eFacMast = eFacMast;
		}
		public async Task<List<EfacMastDto>> GetAllEFacMast()
		{
			return await _eFacMast.GetAllEFacMast();
		}
		public async Task<int> AddlEFacMast(EfacMastDto efacMast)
		{
			return await _eFacMast.AddEFacMast(efacMast);
		}
		public async Task<int> UpdatelEFacMast(EfacMastDto efacMast)
		{
			return await _eFacMast.UpdateEFacMast(efacMast);
		}
		public async Task<int> DeletelEFacMast(short EF_Code)
		{
			return await _eFacMast.DeleteEFacMast(EF_Code);
		}
	}
}
