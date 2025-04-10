using Acc.Data.Interfaces;
using Acc.Shared.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Repositories
{
	public class TIncMastRepository : ITIncMastRepository
	{
		private readonly CommonMethods _commonMethods;

		public TIncMastRepository(CommonMethods commonMethods)
		{
			_commonMethods = commonMethods;
		}
		public async Task<string?> GetTIncPer(int pintTIncCode)
		{
			return await _commonMethods.SearchTextAsync<string>("TIncMast", "TIN_Code", pintTIncCode.ToString(), "Per");
		}
	}
}
