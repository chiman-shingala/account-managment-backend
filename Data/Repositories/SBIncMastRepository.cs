using Acc.Data.Interfaces;
using Acc.Shared.Common;
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

		public SBIncMastRepository(CommonMethods commonMethods)
		{
			_commonMethods = commonMethods;
		}
		public async Task<string?> GetSBIncPer(int pintSBIncCode)
		{
			return await _commonMethods.SearchTextAsync<string>("SBIncMast", "SBIN_Code", pintSBIncCode.ToString(), "Per");
		}
	}
}
