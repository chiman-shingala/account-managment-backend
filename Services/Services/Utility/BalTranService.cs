using Acc.Data.Interfaces.IUtility;
using Acc.Services.Interfaces.Utility;
using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Services.Utility
{
	public class BalTranService : IBalTranService
	{
		private readonly IBalTranRepository _balTran;

		public BalTranService(IBalTranRepository balTran)
		{
			_balTran = balTran;
		}
		public async Task<int> StockTran(BalTranDto balTran)
		{
			return await _balTran.StockTran(balTran);
		}
		public async Task<int> BalTran(BalTranDto balTran)
		{
			return await _balTran.BalTran(balTran);
		}		
	}
}
