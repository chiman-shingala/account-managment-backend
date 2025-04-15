using Acc.Data.Interfaces;
using Acc.Shared.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Repositories
{
	public class EFacMastRepository : IEFacMastRepository
	{
		private readonly CommonMethods _commonMethods;

		public EFacMastRepository(CommonMethods commonMethods)
		{
			_commonMethods = commonMethods;
		}
		public async Task<string?> GetEFacPer(int pintEFCode)
		{
			return await _commonMethods.SearchTextAsync<string>("EFacMast", "EF_Code", pintEFCode.ToString(), "Per");
		}
	}
}
