using Acc.Data.Interfaces.IRapaport;
using Acc.Services.Interfaces.Rapaport;
using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Services.Rapaport
{
	public class RapDiscService : IRapDiscService
	{
		private readonly IRapDiscRepository _rapDiscRepository;

		public RapDiscService(IRapDiscRepository rapDiscRepository)
		{
			_rapDiscRepository = rapDiscRepository;
		}
		public async Task<List<RapDiscDto>> GetAllRapDisc(int SZ_Code, string S_Code)
		{
			return await _rapDiscRepository.GetAllRapDisc(SZ_Code, S_Code);
		}
		public async Task<int> AddRapDisc(InsertRapDiscDto RapDiscDto)
		{
			return await _rapDiscRepository.AddRapDisc(RapDiscDto);
		}
		public async Task<int> UpdateRapDisc(InsertRapDiscDto RapDiscDto)
		{
			return await _rapDiscRepository.UpdateRapDisc(RapDiscDto);
		}
		public async Task<int> DeleteRapDisc(short C_Code,short SZ_Code, string S_Code)
		{
			return await _rapDiscRepository.DeleteRapDisc(C_Code,SZ_Code,S_Code);
		}
	}
}
