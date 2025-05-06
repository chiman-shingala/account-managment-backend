using Acc.Data.Interfaces.ITransaction;
using Acc.Services.Interfaces.Transaction;
using Acc.Shared.Dtos;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;

namespace Acc.Services.Services.Transaction
{
	public class PurEntService : IPurEntService
	{
		private readonly IPurEntRepository _purEntRepository;

		public PurEntService(IPurEntRepository purEntRepository)
		{
			_purEntRepository = purEntRepository;
		}
		
		public async Task<int> AddSum(PBillHDto pBillHDto)
		{
			return await _purEntRepository.AddSum(pBillHDto);
		}
		public async Task<string> SavePurchaseAsync(SavePurchaseRequestDto requestDto)
		{
			//if (Global.IsWithinAccYear(Val.DTDBDate(txtTrnDate.Text)) == false)
			//{
			//	Val.Message("Transaction Is Not In Current Accounting Year", "", MessageBoxIcon.Information);
			//	return;
			//}

			if (!string.IsNullOrEmpty(requestDto.InvNo))
			{
				var pBillHdto = new PBillHDto
				{
					Oper = requestDto.Oper,
					AcYear = requestDto.AcYear,
					Comp_Code = requestDto.Comp_Code,
					InvNo = requestDto.InvNo,
				};
				var invoiceNo = await _purEntRepository.GetInvoiceNo(pBillHdto.InvNo, pBillHdto.AcYear, pBillHdto.Comp_Code, pBillHdto.Oper);
				if (invoiceNo != 0)
				{
					return $"Invoice No is already entered for Transaction No: {invoiceNo}";
				}
			}			
			var pBillH = new PBillHDto
			{
				TrnNo = requestDto.TrnNo,
				InvNo = requestDto.InvNo,
				CnCy = requestDto.CnCy,
				Conv = requestDto.Conv,
				S_Carat = requestDto.S_Carat,
				Amount = requestDto.Amount,
				NetAmt = requestDto.NetAmt,
				TrnDate = requestDto.TrnDate,
				P_Code = requestDto.P_Code,
				DueDay = requestDto.DueDay,
				DueDate = requestDto.DueDate,
				Remark = requestDto.Remark,
				B_Code = requestDto.B_Code,
				Pdis = requestDto.PDis,
				Pcom = requestDto.PCom,
				CanInv = requestDto.CanInv,
				TermAmt1 = requestDto.TermAmt1,
				TermAmt2 = requestDto.TermAmt2,
				TermAmt3 = requestDto.TermAmt3,
				TermAmt4 = requestDto.TermAmt4,
				TermAmt5 = requestDto.TermAmt5,
				Stype = requestDto.SType,
				Term2 = requestDto.Term2,
				Term3 = requestDto.Term3,
				Term4 = requestDto.Term4,
				Term5 = requestDto.Term5,
				AmtDiff = requestDto.AmtDiff,
				AcYear = requestDto.AcYear,
				Comp_Code = requestDto.Comp_Code,
				AdvReceived = requestDto.AdvReceived,
				Br_Code = requestDto.BR_Code,
				Brper = requestDto.BrPer,
				Bramount = requestDto.BrAmount,
				Lp1 = requestDto.LP1,
				Lt1 = requestDto.LT1,
				Lp2 = requestDto.LP2,
				Lt2 = requestDto.LT2,
				IsBreaking = requestDto.IsBreaking,
				Dp_Code = requestDto.DP_Code,
				IsPending = requestDto.IsPending,
				IsBill = requestDto.IsBill,
				PrtrnNo = requestDto.PRTrnNo,
				PracYear = requestDto.PRAcYear,
				Prcomp_Code = requestDto.PrcompCode,
				PrinvNo = requestDto.PRInvNo,
				Pramount = requestDto.PRAmount,
				Luser = requestDto.Luser,
				TrnTime = DateTime.Now,
				CompName = requestDto.CompName,
				CDate = DateTime.Now,
				CTime = DateTime.Now,
				IsChg = requestDto.IsChg,
				Oper = requestDto.Oper
			};
			var storeTrnNo = await _purEntRepository.AddSum(pBillH);

			pBillH.TrnNo = storeTrnNo;	
			requestDto.TrnNo = storeTrnNo;
			var saveDetResult = await _purEntRepository.SaveDet(requestDto);
			if (saveDetResult == 1)
			{
				return "Purchase Payment Already Done For This Entry";
			}else if(saveDetResult == 2)
			{
				return "First Delete Purchase Return Entry";
			}else if(saveDetResult == 3)
			{
				return "Purchase Payment Already Done For This Entry";
			}else if(saveDetResult == 999)
			{
				return "Delete Entry Again";
			}

				var trnMast = new TrnMastDto
				{
					TrnNo = storeTrnNo,
					InvType = "P",
					SrNo = 1,
					TrnType = "C",
					TrnDate = requestDto.TrnDate,
					P_Code = requestDto.P_Code,
					Amount = requestDto.Amount,
					Remark = $"Invoice No : {requestDto.InvNo}",
					Aconv = requestDto.Aconv,
					Pconv = requestDto.PConv,
					Ac_Code = "PURCP",
					//AcnCy = _StrCnCy,   
					//PcnCy = _StrCnCy,
					AcYear = requestDto.AcYear,
					Comp_Code = requestDto.Comp_Code,
					TrnTime = DateTime.Now
				};
			await _purEntRepository.AddTrnMast(trnMast);
			InitializePBillH(requestDto);
			_purEntRepository.SaveDetPktEnt(requestDto);

			return "Record Succesfully";
		}
		private PBillHDto InitializePBillH(SavePurchaseRequestDto requestDto)
		{
			// Initialize and populate the PBillHDto object
			var pBillH = new PBillHDto
			{
				TrnNo = requestDto.TrnNo,  
				InvNo = requestDto.InvNo, 
				CnCy = requestDto.CnCy ?? "",  
				Conv = requestDto.Conv,  
				S_Carat = requestDto.S_Carat, 
				Amount = requestDto.Amount,  
				NetAmt = requestDto.NetAmt,  
				TrnDate = requestDto.TrnDate, 
				P_Code = requestDto.P_Code,  
				DueDay = requestDto.DueDay,  
				DueDate = requestDto.DueDate,  
				Remark = requestDto.Remark,  
				B_Code = requestDto.B_Code,  
				Pdis = requestDto.PDis,  
				Pcom = requestDto.PCom,  
				Oper = requestDto.Oper,
				CanInv = requestDto.CanInv,				 
				TermAmt1 = requestDto.TermAmt1, 
				TermAmt2 = requestDto.TermAmt2,  
				TermAmt3 = requestDto.TermAmt3,  
				TermAmt4 = requestDto.TermAmt4,  
				TermAmt5 = requestDto.TermAmt5,  
				Stype = requestDto.SType,  
				Term2 = requestDto.Term2,  
				Term3 = requestDto.Term3,  
				Term4 = requestDto.Term4,  
				Term5 = requestDto.Term5,  
				AmtDiff = requestDto.AmtDiff, 
				AcYear = requestDto.AcYear,  
				Comp_Code = requestDto.Comp_Code,  
				Luser = requestDto.Luser,  
				TrnTime = DateTime.Now,  
				PrtrnNo = requestDto.PRTrnNo,
				PracYear = requestDto.PRAcYear,
				Prcomp_Code = requestDto.PrcompCode,  
				PrinvNo = requestDto.PRInvNo,  
				Pramount = requestDto.PRAmount, 
				AdvReceived = requestDto.AdvReceived,
				Br_Code = requestDto.BR_Code,  
				Brper = requestDto.BrPer, 
				Bramount = requestDto.BrAmount,  
				Lp1 = requestDto.LP1,  
				Lt1 = requestDto.LT1,  
				Lp2 = requestDto.LP2,  
				Lt2 = requestDto.LT2,  
				//CompName = requestDto.Comp_Code,
				CDate = DateTime.Now,  
				CTime = DateTime.Now,  
				IsChg = requestDto.IsChg,  
				IsBreaking = requestDto.IsBreaking,  
				Dp_Code = requestDto.DP_Code,  
				IsPending = requestDto.IsPending,
				IsBill = requestDto.IsBill,
				PId = requestDto.Pid 
			};

			return pBillH;
		}
	}
}
