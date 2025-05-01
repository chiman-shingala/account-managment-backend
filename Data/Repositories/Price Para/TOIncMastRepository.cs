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
	public class TOIncMastRepository : ITOIncMastRepository
	{
		private readonly CommonMethods _commonMethods;
		private readonly IDRepository _dRepository;

		public TOIncMastRepository(CommonMethods commonMethods,IDRepository dRepository)
		{
			_commonMethods = commonMethods;
			_dRepository = dRepository;
		}
		public async Task<string?> GetTOIncPer(int pintTOIncCode)
		{
			return await _commonMethods.SearchTextAsync<string>("TOIncMast", "TOIN_Code", pintTOIncCode.ToString(), "Per");
		}
		public async Task<List<TOIncMastDto>> GetAllTOIncMast()
		{
			return await _dRepository.GetAll<TOIncMastDto>("SP_MastTOIncMastFill");
		}
		public async Task<int> AddTOIncMast(TOIncMastDto tOIncMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_TOIncMastSave", tOIncMast);
		}
		public async Task<int> UpdateTOIncMast(TOIncMastDto tOIncMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_TOIncMastSave", tOIncMast);
		}
		public async Task<int> DeleteTOIncMast(short TOIN_Code)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_UtilTOIncMastDel", new { TOIN_Code });
		}
	}
}
