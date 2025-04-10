using Acc.Data.Interfaces.IMaster;
using Acc.Data.Repository.Interface;
using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Repositories.Master
{
	public class RemaindMastRepository : IRemaindMastRepository
	{
		private readonly IDRepository _dRepository;

		public RemaindMastRepository(IDRepository dRepository)
		{
			_dRepository = dRepository;
		}
		public async Task<List<RemaindMastDto>> GetAllRemaindMast()
		{
			return await _dRepository.GetAll<RemaindMastDto>("SP_MastRemaindMastFill");
		}
		public async Task<int> AddRemaindMast(RemaindMastDto remaindMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_RemaindMastSave", remaindMast);
		}
		public async Task<int> UpdateRemaindMast(RemaindMastDto remaindMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_RemaindMastSave", remaindMast);
		}
		public async Task<int> DeleteRemaindMast(string Rem_Code)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_UtilRemaindMastDel", new { Rem_Code });
		}
	}
}
