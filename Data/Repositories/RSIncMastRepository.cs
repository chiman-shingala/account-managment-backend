using Acc.Data.Interfaces;
using Acc.Shared.Common;
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

		public RSIncMastRepository(CommonMethods commonMethods)
		{
			_commonMethods = commonMethods;
		}
		public async Task<string?> GetRSIncPer(int pintRSIncCode)
		{
			return await _commonMethods.SearchTextAsync<string>("RSIncMast", "RSIN_Code", pintRSIncCode.ToString(), "Per");
		}
	}
}
