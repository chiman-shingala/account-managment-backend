using Acc.Data.Interfaces;
using Acc.Data.Repository.Interface;
using Acc.Shared.Common;
using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Repositories
{
	public class BrnMastRepository : IBrnMastRepository
	{
		private readonly CommonMethods _commonMethods;
		private readonly IDRepository _dRepository;

		public BrnMastRepository(CommonMethods commonMethods,IDRepository dRepository)
		{
			_commonMethods = commonMethods;
			_dRepository = dRepository;
		}
		public async Task<string?> GetBrnPer(int pintBRNCode)
		{
			return await _commonMethods.SearchTextAsync<string>("BrnMast", "BRN_Code", pintBRNCode.ToString(), "Per");
		}
		public async Task<List<BrnMastDto>> GetAllBrnMast()
		{
			return await _dRepository.GetAll<BrnMastDto>("SP_MastBrnMastFill");
		}
		public async Task<int> AddBrnMast(BrnMastDto brnMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_BrnMastSave", brnMast);
		}
		public async Task<int> UpdateBrnMast(BrnMastDto brnMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_BrnMastSave", brnMast);
		}
		public async Task<int> DeleteBrnMast(short BRN_Code)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_UtilBrnMastDel", new { BRN_Code });
		}
	}
}
