using Acc.Data.Interfaces.ITransaction;
using Acc.Services.Interfaces.Transaction;
using Acc.Shared.Dtos;
namespace Acc.Services.Services.Transaction
{
	public class PurEntService : IPurEntService
	{
		private readonly IPurEntRepository _purEntRepository;
		private readonly IPacketEntRepository _packetEntRepository;

		public PurEntService(IPurEntRepository purEntRepository,IPacketEntRepository packetEntRepository)
		{
			_purEntRepository = purEntRepository;
			_packetEntRepository = packetEntRepository;
		}

		public async Task<int> AddSum(PBillHDto pBillHDto)
		{
			return await _purEntRepository.AddSum(pBillHDto);
		}
		public async Task<string> SavePurchaseAsync(SavePurchaseRequestDto requestDto)
		{
			try
			{
				if (!requestDto.CanInv) 
				{
					//if (PurchaseValidation(requestDto, out string errorMessage) == false)
					//{
					//	return errorMessage;
					//}

					if (requestDto.Amount == 0)
					{
						return "Total Amount Is Required";
					}

					// Check if any purchase entry detail has zero amount
					bool blnDelMsg = false;
					if (requestDto.PurchaseEntryDetails != null)
					{
						foreach (var ugRow in requestDto.PurchaseEntryDetails)
						{
							if (ugRow.Amount == 0)
							{
								blnDelMsg = true;
								break;
							}
						}
					}

					if (blnDelMsg)
					{
						if (!requestDto.Confirmed) 
						{
							return "Records which have 0 (Zero) Amount will be deleted. Please confirm.";
						}
					}
				}
				else
				{
					if (requestDto.TrnNo == 0)
					{
						return "Transaction No. is required";
					}

					if (string.IsNullOrWhiteSpace(requestDto.TrnDate.ToString()))
					{
						return "Date is required";
					}

					if (string.IsNullOrWhiteSpace(requestDto.P_Code))
					{
						return "Party is required";
					}
				}

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

				if (requestDto.TrnNo > 0)
				{
					List<string> diffAvgRateList = new List<string>();
					if (requestDto.checkAvgRates != null && requestDto.PurchaseEntryDetails != null)
					{
						foreach (var dRow in requestDto.checkAvgRates)
						{
							foreach (var ugRow in requestDto.PurchaseEntryDetails)
							{
								if (dRow.PId.ToString().Trim() == ugRow.PId?.Trim() && (decimal)dRow.AvgRate != (decimal)ugRow.AvgRate)
								{
									diffAvgRateList.Add(dRow.PId.ToString());
									break;
								}
							}
						}
					}
					if (diffAvgRateList.Any() && !requestDto.Confirmed)
					{
						string _strDupliStockNoList = string.Join(Environment.NewLine, diffAvgRateList);
						return $"$Do You Want To Update CurCost For This Packet ?{_strDupliStockNoList}";
					}
					requestDto.IsChg = diffAvgRateList.Any() ? "Y" : "N";
				}
				else
				{
					requestDto.IsChg = "N";
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
				}
				else if (saveDetResult == 2)
				{
					return "First Delete Purchase Return Entry";
				}
				else if (saveDetResult == 3)
				{
					return "Purchase Payment Already Done For This Entry";
				}
				else if (saveDetResult == 999)
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
				await _purEntRepository.SaveDetPktEnt(requestDto);

				if (requestDto.PurchaseEntryDetails != null)
				{
					foreach (var item in requestDto.PurchaseEntryDetails)
					{
						if (string.IsNullOrEmpty(item.PId)) continue;
						PktMastDto pktMastDto = new PktMastDto
						{
							PId = requestDto.Pid,
							Comp_Code = requestDto.Comp_Code,
							AcYear = requestDto.AcYear,
						};
						await _packetEntRepository.UpdateCostCont(pktMastDto);
					}
				}
				return "Record Succesfully";
			}
			catch (Exception ex)
			{
				return ex.Message;
			}

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
		public bool PurchaseValidation(SavePurchaseRequestDto request, out string errorMessage)
		{
			errorMessage = string.Empty;

			if (request.TrnDate == null)
			{
				errorMessage = "Transaction Date is required.";
				return false;
			}

			if (request.SType != "X" && string.IsNullOrWhiteSpace(request.DP_Code))
			{
				errorMessage = "Department is required.";
				return false;
			}

			if (string.IsNullOrWhiteSpace(request.P_Code))
			{
				errorMessage = "Party is required.";
				return false;
			}

			if (request.Oper == "D" && request.S_Carat == 0)
			{
				errorMessage = "Total Carat is required.";
				return false;
			}

			if (request.NetAmt == 0)
			{
				errorMessage = "Net Amount is required.";
				return false;
			}

			//if (request.PayAmt == 0)
			//{
			//	errorMessage = "Round Amount is required.";
			//	return false;
			//}

			if (request.Conv == 0)
			{
				errorMessage = "Currency Conversion is required.";
				return false;
			}

			if (string.IsNullOrWhiteSpace(request.CnCy))
			{
				errorMessage = "Currency is required.";
				return false;
			}

			decimal totalTermAmt = request.TermAmt1 + request.TermAmt2 + request.TermAmt3 + request.TermAmt4 + request.TermAmt5;

			if (totalTermAmt != 0)
			{
				if (Math.Round(totalTermAmt, 2) != Math.Round(request.PayAmt, 2))
				{
					errorMessage = "Terms Amount must be exactly the same as Round Amount.";
					return false;
				}
			}

			if (request.BrPer != 0 && string.IsNullOrWhiteSpace(request.B_Code))
			{
				errorMessage = "Broker is required.";
				return false;
			}

			if (request.NetAmt != (request.PayAmt + request.AmtDiff))
			{
				errorMessage = "Net Amount must be equal to (Round Amount + Diff. Amount).";
				return false;
			}

			return true;
		}
		public async Task<string> DeletePurEnt(int TrnNo,int AcYear,string Comp_Code)
		{
			// implementation is pending for  UpdatePacketCost and UpdateCostCont
			return await _purEntRepository.DeletePurEnt(TrnNo,AcYear,Comp_Code);
		}
	}
}
