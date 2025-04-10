using Acc.Data.Interfaces;
using Acc.Shared.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Repositories
{
	public class CulMastRepository : ICulMastRepository
	{
		private readonly CommonMethods _commonMethods;

		public CulMastRepository(CommonMethods commonMethods)
		{
			_commonMethods = commonMethods;
		}
		public async Task<string?> GetCulPer(int pintCUCode)
		{
			return await _commonMethods.SearchTextAsync<string>("CulMast", "CU_Code", pintCUCode.ToString(), "Per");
		}
	}
}
