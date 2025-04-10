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
	public class RapDiscRepository : IRapDiscRepository
	{
		private readonly IDRepository _dRepository;

		public RapDiscRepository(IDRepository dRepository)
		{
			_dRepository = dRepository;
		}
		public async Task<List<RapDiscDto>> GetAllRapDisc(int SZ_Code,string S_Code)
		{
			return await _dRepository.GetAll<RapDiscDto>("SP_RapDiscEntFill",new {SZ_Code,S_Code});
		}
		public async Task<int> AddRapDisc(InsertRapDiscDto rapDiscDto)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_RapDiscEntSave", rapDiscDto);
		}
		public async Task<int> UpdateRapDisc(InsertRapDiscDto rapDiscDto)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_RapDiscEntSave", rapDiscDto);
		}
		public async Task<int> DeleteRapDisc(short C_CODE,short SZ_Code,string S_Code)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_RapDiscEntDel", new { C_CODE,SZ_Code,S_Code });
		}
	}
}
