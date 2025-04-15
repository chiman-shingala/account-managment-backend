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
	public class SOIncMastRepository : ISOIncMastRepository
	{
		private readonly CommonMethods _commonMethods;

		public SOIncMastRepository(CommonMethods commonMethods)
		{
			_commonMethods = commonMethods;
		}
		public async Task<string?> GetSOIncPer(int pintSOIncCode)
		{
			return await _commonMethods.SearchTextAsync<string>("SOIncMast", "SOIN_Code", pintSOIncCode.ToString(), "Per");
		}
	}
}
