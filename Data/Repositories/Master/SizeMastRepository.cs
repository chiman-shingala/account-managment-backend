using Acc.Data.Interfaces.IMaster;
using Acc.Data.Repository.Interface;
using Acc.Shared.Common;
using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Repositories.Master
{
	public class SizeMastRepository : ISizeMastRepository
	{
		private readonly IDRepository _dRepository;
		private readonly CommonMethods _commonMethods;

		public SizeMastRepository(IDRepository dRepository,CommonMethods commonMethods)
		{
			_dRepository = dRepository;
			_commonMethods = commonMethods;
		}
		public async Task<List<SizeMastDto>> GetAllSize()
		{
			return await _dRepository.GetAll<SizeMastDto>("SP_MastSizeMastFill");
		}
		public async Task<int> AddSize(SizeMastDto sizeMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_SizeMastSave", sizeMast);
		}
		public async Task<int> UpdateSize(SizeMastDto sizeMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_SizeMastSave", sizeMast);
		}
		public async Task<int> DeleteSize(short SZ_Code)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_UtilSizeMastSizeDel", new { SZ_Code });
		}
		public async Task<int> GetSizeCode(double pdblCarat)
		{
			return await _commonMethods.SearchText<int>("SizeMast", "F_Size <= " + pdblCarat.ToString() + " And T_Size >= " + pdblCarat.ToString(), "SZ_Code", 1);
		}		
	}
}
