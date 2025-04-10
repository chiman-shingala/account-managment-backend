using Acc.Data.Interfaces;
using Acc.Shared.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Repositories
{
	public class TBIncMastRepository : ITBIncMastRepository
	{
		private readonly CommonMethods _commonMethods;

		public TBIncMastRepository(CommonMethods commonMethods)
		{
			_commonMethods = commonMethods;
		}
		public async Task<string?> GetTBIncPer(int pintTBIncCode)
		{
			return await _commonMethods.SearchTextAsync<string>("TBIncMast", "TBIN_Code", pintTBIncCode.ToString(), "Per");
		}
	}
}
