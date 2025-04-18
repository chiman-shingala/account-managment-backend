using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Interfaces.IUtility
{
	public interface IBalTranRepository
	{
		Task<int> StockTran(BalTranDto balTran);
		Task<int> BalTran(BalTranDto balTran);
	}
}
