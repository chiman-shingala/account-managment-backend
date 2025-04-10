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
	public class CutDiscRepository : ICutDiscRepository
	{
		private readonly IDRepository _dRepository;

		public CutDiscRepository(IDRepository dRepository)
		{
			_dRepository = dRepository;
		}
		public async Task<List<CutDiscDto>> GetAllCutDisc(int SZ_Code, string S_Code,int CT_Code)
		{
			return await _dRepository.GetAll<CutDiscDto>("SP_CutDiscEntFill", new { SZ_Code, S_Code,CT_Code });
		}
		public async Task<int> AddCutDisc(InsertCutDiscDto cutDiscDto)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_CutDiscEntSave", cutDiscDto);
		}
		public async Task<int> UpdateCutDisc(InsertCutDiscDto cutDiscDto)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_CutDiscEntSave", cutDiscDto);
		}
		public async Task<int> DeleteCutDisc(short C_CODE, short SZ_Code, string S_Code,int CT_Code)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_CutDiscEntDel", new { C_CODE, SZ_Code, S_Code,CT_Code });
		}
	}
}
