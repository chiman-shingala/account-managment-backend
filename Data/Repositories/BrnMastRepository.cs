using Acc.Data.Interfaces;
using Acc.Shared.Common;
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

		public BrnMastRepository(CommonMethods commonMethods)
		{
			_commonMethods = commonMethods;
		}
		public async Task<string?> GetBrnPer(int pintBRNCode)
		{
			return await _commonMethods.SearchTextAsync<string>("BrnMast", "BRN_Code", pintBRNCode.ToString(), "Per");
		}
	}
}
