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
	public class RSIncMastRepository : IRSIncMastRepository
	{
		private readonly CommonMethods _commonMethods;
		private readonly IDRepository _dRepository;

		public RSIncMastRepository(CommonMethods commonMethods,IDRepository dRepository)
		{
			_commonMethods = commonMethods;
			_dRepository = dRepository;
		}
		public async Task<string?> GetRSIncPer(int pintRSIncCode)
		{
			return await _commonMethods.SearchTextAsync<string>("RSIncMast", "RSIN_Code", pintRSIncCode.ToString(), "Per");
		}
		public async Task<List<RsincMastDto>> GetAllRSIncMast()
		{
			return await _dRepository.GetAll<RsincMastDto>("SP_MastSOIncMastFill");
		}
		public async Task<int> AddRSIncMast(RsincMastDto rsincMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_RSIncMastSave", rsincMast);
		}
		public async Task<int> UpdateRSIncMast(RsincMastDto rsincMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_RSIncMastSave", rsincMast);
		}
		public async Task<int> DeleteRSIncMast(short RSIN_Code)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_UtilRSIncMastDel", new { RSIN_Code });
		}
	}
}
