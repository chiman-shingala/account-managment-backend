using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Interfaces.Transaction
{
	public interface IPurEntService
	{
		Task<int> AddSum(PBillHDto pBillHDto);
		Task<string> SavePurchaseAsync(SavePurchaseRequestDto requestDto);
	}
}
