using Acc.Data.Interfaces.IMaster;
using Acc.Services.Interfaces;
using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Services
{
	public class CutMastService : ICutMastService
	{
		private readonly ICutMastRepository _cutMastRepository;

		public CutMastService(ICutMastRepository cutMastRepository)
		{
			_cutMastRepository = cutMastRepository;
		}
		public async Task<List<CutMastDto>> GetAllCuts()
		{
			return await _cutMastRepository.GetAllCuts();
		}
		public async Task<int> AddCut(CutMastDto cutMast)
		{
			return await _cutMastRepository.AddCut(cutMast);
		}
		public async Task<int> UpdateCut(CutMastDto cutMast)
		{
			return await _cutMastRepository.UpdateCut(cutMast);
		}
		public async Task<int> DeleteCut(short CT_Code)
		{
			return await _cutMastRepository.DeleteCut(CT_Code);
		}
	}
}
