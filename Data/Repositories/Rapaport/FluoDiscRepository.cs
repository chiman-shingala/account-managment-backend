using Acc.Data.Interfaces.IRapaport;
using Acc.Data.Repository.Interface;
using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Repositories.Rapaport
{
	public class FluoDiscRepository : IFluoDiscRepository
	{
		private readonly IDRepository _dRepository;

		public FluoDiscRepository(IDRepository dRepository)
		{
			_dRepository = dRepository;
		}
		public async Task<List<FluoDiscDto>> GetAllFluoDisc(int SZ_Code, string S_Code, int FL_Code)
		{
			return await _dRepository.GetAll<FluoDiscDto>("SP_FluoDiscEntFill", new { SZ_Code, S_Code, FL_Code });
		}
		public async Task<int> AddFluoDisc(InsertFluoDiscDto fluoDiscDto)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_FluoDiscEntSave", fluoDiscDto);
		}
		public async Task<int> UpdateFluoDisc(InsertFluoDiscDto fluoDiscDto)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_FluoDiscEntSave", fluoDiscDto);
		}
		public async Task<int> DeleteFluoDisc(short C_CODE, short SZ_Code, string S_Code, int FL_Code)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_FluoDiscEntDel", new { C_CODE, SZ_Code, S_Code, FL_Code });
		}
	}
}
