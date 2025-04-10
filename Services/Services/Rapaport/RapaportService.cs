using Acc.Data.Interfaces.IRapaport;
using Acc.Services.Interfaces.Rapaport;
using Acc.Shared.Dtos;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Services.Rapaport
{
	public class RapaportService : IRapaportService
	{
		private readonly IRapaportRepository _rapaportRepository;

		public RapaportService(IRapaportRepository rapaportRepository)
		{
			_rapaportRepository = rapaportRepository;
		}
		public async Task<List<RapaportDto>> GetRapaport(int SZ_Code, string S_Code)
		{
			return await _rapaportRepository.GetAllRapaport(SZ_Code, S_Code);
		}
		public async Task<int> AddRapaport(InsertRapaportDto rapaportDto)
		{
			return await _rapaportRepository.AddRapaport(rapaportDto);
		}
		public async Task<int> UpdateRapaport(InsertRapaportDto rapaportDto)
		{
			return await _rapaportRepository.UpdateRapaport(rapaportDto);
		}
	}
}
