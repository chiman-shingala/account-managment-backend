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
	public class TOIncMastRepository : ITOIncMastRepository
	{
		private readonly CommonMethods _commonMethods;
		public TOIncMastRepository(CommonMethods commonMethods)
		{
			_commonMethods = commonMethods;
		}
		public async Task<string?> GetTOIncPer(int pintTOIncCode)
		{
			return await _commonMethods.SearchTextAsync<string>("TOIncMast", "TOIN_Code", pintTOIncCode.ToString(), "Per");
		}
	}
}
