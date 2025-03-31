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
	public class SizeMastRepository : ISizeMastRepository
	{
		private readonly IDRepository _dRepository;

		public SizeMastRepository(IDRepository dRepository)
		{
			_dRepository = dRepository;
		}
		public async Task<List<SizeMastDto>> GetAllSize()
		{
			return await _dRepository.GetAll<SizeMastDto>("SP_MastSizeMastFill");
		}
		public async Task<int> AddSize(SizeMastDto sizeMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_UtilSizeMastCreateSize", sizeMast);
		}
		public async Task<int> UpdateSize(SizeMastDto sizeMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_UtilSizeMastUpdateSize", sizeMast);
		}
		public async Task<int> DeleteSize(short SZ_Code)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_UtilSizeMastSizeDel", new { SZ_Code });
		}
	}
}
