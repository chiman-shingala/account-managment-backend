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
	public class CutDiscService : ICutDiscService
	{
		private readonly ICutDiscRepository _cutDiscRepository;

		public CutDiscService(ICutDiscRepository cutDiscRepository)
		{
			_cutDiscRepository = cutDiscRepository;
		}
		public async Task<List<CutDiscDto>> GetAllCutDisc(int SZ_Code, string S_Code,int CT_Code)
		{
			return await _cutDiscRepository.GetAllCutDisc(SZ_Code, S_Code,CT_Code);
		}
		public async Task<int> AddCutDisc(InsertCutDiscDto cutDiscDto)
		{
			return await _cutDiscRepository.AddCutDisc(cutDiscDto);
		}
		public async Task<int> UpdateCutDisc(InsertCutDiscDto cutDiscDto)
		{
			return await _cutDiscRepository.UpdateCutDisc(cutDiscDto);
		}
		public async Task<int> DeleteCutDisc(short C_Code, short SZ_Code, string S_Code,int CT_Code)
		{
			return await _cutDiscRepository.DeleteCutDisc(C_Code,SZ_Code,S_Code,CT_Code);
		}
	}
}
