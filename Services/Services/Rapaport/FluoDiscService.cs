using Acc.Data.Interfaces.IRapaport;
using Acc.Data.Repositories.Rapaport;
using Acc.Services.Interfaces.Rapaport;
using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Services.Rapaport
{
	public class FluoDiscService : IFluoDiscService
	{
		private readonly IFluoDiscRepository _fluoDiscRepository;

		public FluoDiscService(IFluoDiscRepository fluoDiscRepository)
		{
			_fluoDiscRepository = fluoDiscRepository;
		}
		public async Task<List<FluoDiscDto>> GetAllFluoDisc(int SZ_Code, string S_Code, int FL_Code)
		{
			return await _fluoDiscRepository.GetAllFluoDisc(SZ_Code,S_Code,FL_Code);
		}
		public async Task<int> AddFluoDisc(InsertFluoDiscDto fluoDiscDto)
		{
			return await _fluoDiscRepository.AddFluoDisc(fluoDiscDto);
		}
		public async Task<int> UpdateCutDisc(InsertFluoDiscDto fluoDiscDto)
		{
			return await _fluoDiscRepository.UpdateFluoDisc(fluoDiscDto);
		}
		public async Task<int> DeleteCutDisc(short C_Code, short SZ_Code, string S_Code, int FL_Code)
		{
			return await _fluoDiscRepository.DeleteFluoDisc(C_Code,SZ_Code,S_Code,FL_Code);
		}
	}
}
