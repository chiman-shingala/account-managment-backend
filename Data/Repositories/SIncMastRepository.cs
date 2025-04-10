using Acc.Data.Interfaces;
using Acc.Shared.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Repositories
{
	public class SIncMastRepository : ISIncMastRepository
	{
		private readonly CommonMethods _commonMethods;

		public SIncMastRepository(CommonMethods commonMethods)
		{
			_commonMethods = commonMethods;
		}
		public async Task<string?> GetSIncPer(int pintSIncCode)
		{
			return await _commonMethods.SearchTextAsync<string>("SIncMast", "SIN_Code", pintSIncCode.ToString(), "Per");
		}
	}
}
