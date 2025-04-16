using Acc.Data.Interfaces;
using Acc.Data.Repository.Interface;
using Acc.Shared.Common;
using Acc.Shared.Dtos;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Repositories
{
	public class SOIncMastRepository : ISOIncMastRepository
	{
		private readonly CommonMethods _commonMethods;
		private readonly IDRepository _dRepository;

		public SOIncMastRepository(CommonMethods commonMethods,IDRepository dRepository)
		{
			_commonMethods = commonMethods;
			_dRepository = dRepository;
		}
		public async Task<string?> GetSOIncPer(int pintSOIncCode)
		{
			return await _commonMethods.SearchTextAsync<string>("SOIncMast", "SOIN_Code", pintSOIncCode.ToString(), "Per");
		}
		public async Task<List<SoincMastDto>> GetAllSOIncMast()
		{
			return await _dRepository.GetAll<SoincMastDto>("SP_MastSOIncMastFill");
		}
		public async Task<int> AddSOIncMast(SoincMastDto soincMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_SOIncMastSave", soincMast);
		}
		public async Task<int> UpdateSOIncMast(SoincMastDto soincMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_SOIncMastSave", soincMast);
		}
		public async Task<int> DeleteSOIncMast(short SOIN_Code)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_UtilSOIncMastDel", new { SOIN_Code });
		}
	}
}
