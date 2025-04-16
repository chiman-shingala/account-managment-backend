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
	public class SBIncMastRepository : ISBIncMastRepository
	{
		private readonly CommonMethods _commonMethods;
		private readonly IDRepository _dRepository;

		public SBIncMastRepository(CommonMethods commonMethods,IDRepository dRepository)
		{
			_commonMethods = commonMethods;
			_dRepository = dRepository;
		}
		public async Task<string?> GetSBIncPer(int pintSBIncCode)
		{
			return await _commonMethods.SearchTextAsync<string>("SBIncMast", "SBIN_Code", pintSBIncCode.ToString(), "Per");
		}
		public async Task<List<SbincMastDto>> GetAllSBIncMast()
		{
			return await _dRepository.GetAll<SbincMastDto>("SP_MastSBIncMastFill");
		}
		public async Task<int> AddSBIncMast(SbincMastDto sbincMastDto)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_SBIncMastSave", sbincMastDto);
		}
		public async Task<int> UpdateSBIncMast(SbincMastDto sbincMastDto)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_SBIncMastSave", sbincMastDto);
		}
		public async Task<int> DeleteSBIncMast(short SBIN_Code)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_UtilSBIncMastDel", new { SBIN_Code });
		}
	}
}
