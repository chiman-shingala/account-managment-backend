using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Interfaces.ITransaction
{
	public interface IPurEntRepository
	{
		Task<int> AddSum(PBillHDto pBillHDto);
		Task<int> UpdateSum(PBillHDto pBillHDto);
		Task<int> AddTrnMast(TrnMastDto trnMastDto);
		Task<int> UpdateTrnMast(TrnMastDto trnMastDto);
		Task<int> GetInvoiceNo(string InvNo, int AcYear, string Comp_Code, string Oper);
		void SaveDetPktEnt(SavePurchaseRequestDto packetInputs);
		Task<int> SaveDet(SavePurchaseRequestDto pBillHDto);
	}
}
