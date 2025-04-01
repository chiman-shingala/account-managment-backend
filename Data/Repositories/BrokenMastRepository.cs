using Acc.Data.Interfaces;
using Acc.Data.Repository.Interface;
using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Repositories
{
	public class BrokenMastRepository : IBrokenMastRepository
	{
		private readonly IDRepository _dRepository;

		public BrokenMastRepository(IDRepository dRepository)
		{
			_dRepository = dRepository;
		}
		public async Task<List<BrokenMastDto>> GetAllBrokenMast()
		{
			return await _dRepository.GetAll<BrokenMastDto>("SP_MastBrokenMastFill");
		}
		public async Task<int> AddBrokenMast(BrokenMastDto brokenMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_BrokenMastSave", brokenMast);
		}
		public async Task<int> UpdateBrokenMast(BrokenMastDto brokenMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_BrokenMastSave", brokenMast);
		}
		public async Task<int> DeleteBrokenMast(string BRO_Code)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_UtilBrokenMastDel", new { BRO_Code });
		}
	}
}
