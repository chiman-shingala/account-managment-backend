using Acc.Data.Interfaces;
using Acc.Shared.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Repositories
{
	public class HAMastRepository : IHAMastRepository
	{
		private readonly CommonMethods _commonMethods;

		public HAMastRepository(CommonMethods commonMethods)
		{
			_commonMethods = commonMethods;
		}
		public async Task<string?> GetHAPer(int pintHAIncCode)
		{
			return await _commonMethods.SearchTextAsync<string>("HAMast", "HA_Code", pintHAIncCode.ToString(), "Per");
		}
	}
}
