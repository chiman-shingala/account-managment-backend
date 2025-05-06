using Acc.Data.Interfaces.ITransaction;
using Acc.Data.Repository.Interface;
using Acc.Shared.Dtos;
using Dapper;
using System.Data;
using System.Net.NetworkInformation;
using Val = Acc.Shared.Common.CommonMethods;


namespace Acc.Data.Repositories.Transaction
{
	public class PurEntRepository : IPurEntRepository
	{
		private readonly IDRepository _dRepository;
		private readonly IPacketEntRepository _packetEnt;

		public PurEntRepository(IDRepository dRepository, IPacketEntRepository packetEnt)
		{
			_dRepository = dRepository;
			_packetEnt = packetEnt;
		}
		public async Task<int> AddSum(PBillHDto pBillHDto)
		{
			var parameters = new DynamicParameters();

			parameters.Add("@TrnNo", pBillHDto.TrnNo);
			parameters.Add("@InvNo", pBillHDto.InvNo);
			parameters.Add("@TrnDate", pBillHDto.TrnDate);
			parameters.Add("@P_Code", pBillHDto.P_Code);
			parameters.Add("@Conv", pBillHDto.Conv);
			parameters.Add("@CnCy", pBillHDto.CnCy);
			parameters.Add("@S_Carat", pBillHDto.S_Carat);
			parameters.Add("@Amount", pBillHDto.Amount);
			parameters.Add("@NetAmt", pBillHDto.NetAmt);
			parameters.Add("@TermAmt1", pBillHDto.TermAmt1);
			parameters.Add("@TermAmt2", pBillHDto.TermAmt2);
			parameters.Add("@TermAmt3", pBillHDto.TermAmt3);
			parameters.Add("@TermAmt4", pBillHDto.TermAmt4);
			parameters.Add("@TermAmt5", pBillHDto.TermAmt5);
			parameters.Add("@B_Code", pBillHDto.B_Code);
			parameters.Add("@DueDay", pBillHDto.DueDay);
			parameters.Add("@DueDate", pBillHDto.DueDate);
			parameters.Add("@Remark", pBillHDto.Remark);
			parameters.Add("@Oper", pBillHDto.Oper);
			parameters.Add("@Stype", pBillHDto.Stype);
			parameters.Add("@AcYear", pBillHDto.AcYear);
			parameters.Add("@Comp_Code", pBillHDto.Comp_Code);
			parameters.Add("@Pdis", pBillHDto.Pdis);
			parameters.Add("@Pcom", pBillHDto.Pcom);
			parameters.Add("@Term2", pBillHDto.Term2);
			parameters.Add("@Term3", pBillHDto.Term3);
			parameters.Add("@Term4", pBillHDto.Term4);
			parameters.Add("@Term5", pBillHDto.Term5);
			parameters.Add("@AmtDiff", pBillHDto.AmtDiff);
			parameters.Add("@Luser", pBillHDto.Luser);
			parameters.Add("@CanInv", pBillHDto.CanInv);
			parameters.Add("@TrnTime", pBillHDto.TrnTime);
			parameters.Add("@PrtrnNo", pBillHDto.PrtrnNo);
			parameters.Add("@PracYear", pBillHDto.PracYear);
			parameters.Add("@Prcomp_Code", pBillHDto.Prcomp_Code);
			parameters.Add("@PrinvNo", pBillHDto.PrinvNo);
			parameters.Add("@Pramount", pBillHDto.Pramount);
			parameters.Add("@AdvReceived", pBillHDto.AdvReceived);
			parameters.Add("@Br_Code", pBillHDto.Br_Code);
			parameters.Add("@Brper", pBillHDto.Brper);
			parameters.Add("@Bramount", pBillHDto.Bramount);
			parameters.Add("@Lp1", pBillHDto.Lp1);
			parameters.Add("@Lt1", pBillHDto.Lt1);
			parameters.Add("@Lp2", pBillHDto.Lp2);
			parameters.Add("@Lt2", pBillHDto.Lt2);
			parameters.Add("@IsBreaking", pBillHDto.IsBreaking);
			parameters.Add("@Dp_Code", pBillHDto.Dp_Code);
			parameters.Add("@IsBill", pBillHDto.IsBill);
			parameters.Add("@IsPending", pBillHDto.IsPending);

			parameters.Add("@OutTrnNo", dbType: DbType.Int32, direction: ParameterDirection.Output);
			await _dRepository.ExecuteAsyncQuery("SP_PurEntPBillHSave", parameters).ConfigureAwait(false);

			var result = parameters.Get<int>("@OutTrnNo");
			return result;
		}
		public async Task<int> UpdateSum(PBillHDto pBillHDto)
		{
			var parameters = new DynamicParameters();

			parameters.Add("@TrnNo", pBillHDto.TrnNo);
			parameters.Add("@InvNo", pBillHDto.InvNo);
			parameters.Add("@TrnDate", pBillHDto.TrnDate);
			parameters.Add("@P_Code", pBillHDto.P_Code);
			parameters.Add("@Conv", pBillHDto.Conv);
			parameters.Add("@CnCy", pBillHDto.CnCy);
			parameters.Add("@S_Carat", pBillHDto.S_Carat);
			parameters.Add("@Amount", pBillHDto.Amount);
			parameters.Add("@NetAmt", pBillHDto.NetAmt);
			parameters.Add("@TermAmt1", pBillHDto.TermAmt1);
			parameters.Add("@TermAmt2", pBillHDto.TermAmt2);
			parameters.Add("@TermAmt3", pBillHDto.TermAmt3);
			parameters.Add("@TermAmt4", pBillHDto.TermAmt4);
			parameters.Add("@TermAmt5", pBillHDto.TermAmt5);
			parameters.Add("@B_Code", pBillHDto.B_Code);
			parameters.Add("@DueDay", pBillHDto.DueDay);
			parameters.Add("@DueDate", pBillHDto.DueDate);
			parameters.Add("@Remark", pBillHDto.Remark);
			parameters.Add("@Oper", pBillHDto.Oper);
			parameters.Add("@Stype", pBillHDto.Stype);
			parameters.Add("@AcYear", pBillHDto.AcYear);
			parameters.Add("@Comp_Code", pBillHDto.Comp_Code);
			parameters.Add("@Pdis", pBillHDto.Pdis);
			parameters.Add("@Pcom", pBillHDto.Pcom);
			parameters.Add("@Term2", pBillHDto.Term2);
			parameters.Add("@Term3", pBillHDto.Term3);
			parameters.Add("@Term4", pBillHDto.Term4);
			parameters.Add("@Term5", pBillHDto.Term5);
			parameters.Add("@AmtDiff", pBillHDto.AmtDiff);
			parameters.Add("@Luser", pBillHDto.Luser);
			parameters.Add("@CanInv", pBillHDto.CanInv);
			parameters.Add("@TrnTime", pBillHDto.TrnTime);
			parameters.Add("@PrtrnNo", pBillHDto.PrtrnNo);
			parameters.Add("@PracYear", pBillHDto.PracYear);
			parameters.Add("@Prcomp_Code", pBillHDto.Prcomp_Code);
			parameters.Add("@PrinvNo", pBillHDto.PrinvNo);
			parameters.Add("@Pramount", pBillHDto.Pramount);
			parameters.Add("@AdvReceived", pBillHDto.AdvReceived);
			parameters.Add("@Br_Code", pBillHDto.Br_Code);
			parameters.Add("@Brper", pBillHDto.Brper);
			parameters.Add("@Bramount", pBillHDto.Bramount);
			parameters.Add("@Lp1", pBillHDto.Lp1);
			parameters.Add("@Lt1", pBillHDto.Lt1);
			parameters.Add("@Lp2", pBillHDto.Lp2);
			parameters.Add("@Lt2", pBillHDto.Lt2);
			parameters.Add("@IsBreaking", pBillHDto.IsBreaking);
			parameters.Add("@Dp_Code", pBillHDto.Dp_Code);
			parameters.Add("@IsBill", pBillHDto.IsBill);
			parameters.Add("@IsPending", pBillHDto.IsPending);

			parameters.Add("@OutTrnNo", dbType: DbType.String, direction: ParameterDirection.Output);
			await _dRepository.ExecuteAsyncQuery("SP_PurEntPBillHSave", parameters).ConfigureAwait(false);

			var result = parameters.Get<int>("@OutTrnNo");
			return result;
		}
		public async Task<int> AddTrnMast(TrnMastDto trnMastDto)
		{
			var parameters = new DynamicParameters();
			parameters.Add("TrnNo", trnMastDto.TrnNo);
			parameters.Add("InvType", trnMastDto.InvType);
			parameters.Add("SrNo", trnMastDto.SrNo);
			parameters.Add("TrnType", trnMastDto.TrnType);
			parameters.Add("TrnDate", trnMastDto.TrnDate);
			parameters.Add("P_Code", trnMastDto.P_Code);
			parameters.Add("Amount", trnMastDto.Amount);
			parameters.Add("Remark", trnMastDto.Remark);
			parameters.Add("AConv", trnMastDto.Aconv);
			parameters.Add("PConv", trnMastDto.Pconv);
			parameters.Add("AC_Code", trnMastDto.Ac_Code);
			parameters.Add("ACnCy", trnMastDto.AcnCy);
			parameters.Add("PCnCy", trnMastDto.PcnCy);
			parameters.Add("Broker", 0);
			parameters.Add("AcYear", trnMastDto.AcYear);
			parameters.Add("Comp_Code", trnMastDto.Comp_Code);
			parameters.Add("TrnTime", trnMastDto.TrnTime);
			var result = await _dRepository.ExecuteAsyncQuery("SP_TrnMastSave", parameters).ConfigureAwait(false);
			return result;
		}
		public async Task<int> UpdateTrnMast(TrnMastDto trnMastDto)
		{
			var parameters = new DynamicParameters();
			parameters.Add("TrnNo", trnMastDto.TrnNo);
			parameters.Add("InvType", trnMastDto.InvType);
			parameters.Add("SrNo", trnMastDto.SrNo);
			parameters.Add("TrnType", trnMastDto.TrnType);
			parameters.Add("TrnDate", trnMastDto.TrnDate);
			parameters.Add("P_Code", trnMastDto.P_Code);
			parameters.Add("Amount", trnMastDto.Amount);
			parameters.Add("Remark", trnMastDto.Remark);
			parameters.Add("AConv", trnMastDto.Aconv);
			parameters.Add("PConv", trnMastDto.Pconv);
			parameters.Add("AC_Code", trnMastDto.Ac_Code);
			parameters.Add("ACnCy", trnMastDto.AcnCy);
			parameters.Add("PCnCy", trnMastDto.PcnCy);
			parameters.Add("Broker", 0);
			parameters.Add("AcYear", trnMastDto.AcYear);
			parameters.Add("Comp_Code", trnMastDto.Comp_Code);
			parameters.Add("TrnTime", trnMastDto.TrnTime);
			var result = await _dRepository.ExecuteAsyncQuery("SP_TrnMastSave", parameters).ConfigureAwait(false);
			return result;
		}
		public async Task<int> GetInvoiceNo(string InvNo, int AcYear, string Comp_Code, string Oper)
		{				
			var result = await _dRepository.QuerySingleOrDefaultAsync<int>("SP_PurEntGetInvoiceNo", new { InvNo, AcYear, Comp_Code, Oper }).ConfigureAwait(false);
			return result;
		}
		public async Task<int> SaveAssignDet(SavePurchaseRequestDto request, PurchaseEntryDetailDto detail)
		{
			var parameters = new DynamicParameters();
			parameters.Add("TrnNo", request.TrnNo);
			parameters.Add("SrNo", detail.SrNo);
			parameters.Add("TrnDate", request.TrnDate);
			parameters.Add("S_Code", detail.S_Code);
			parameters.Add("Q_Code", detail.Q_Code);
			parameters.Add("C_Code", detail.C_Code);
			parameters.Add("SZ_Code", detail.SZ_Code);
			parameters.Add("Rem", detail.Rem);
			parameters.Add("Conv", request.Conv);
			parameters.Add("CnCy", request.CnCy);
			parameters.Add("S_Carat", detail.S_Carat);
			parameters.Add("Amount", detail.Amount);

			parameters.Add("LP1", detail.LP1);
			parameters.Add("LT1", detail.LT1);
			parameters.Add("LP2", detail.LP2);
			parameters.Add("LT2", detail.LT2);
			parameters.Add("LP3", 0);
			parameters.Add("LT3", 0);

			parameters.Add("SRate", detail.SRate);

			parameters.Add("BR_Code", "");
			parameters.Add("BRPer", 0);
			parameters.Add("BRAmount", 0);

			parameters.Add("I_Code", detail.I_Code);
			parameters.Add("D_Code", detail.D_Code);
			parameters.Add("SN_Code", detail.SN_Code);
			parameters.Add("PId", detail.PId?.Trim());
			parameters.Add("SType", request.SType);
			parameters.Add("Desc1", detail.Desc1);
			parameters.Add("AcYear", request.AcYear);
			parameters.Add("Comp_Code", request.Comp_Code);
			parameters.Add("GAmount", detail.GAmount);

			parameters.Add("PDis", detail.PDis);
			parameters.Add("PDisPer", detail.PDisPer);
			parameters.Add("PCom", detail.PCom);
			parameters.Add("PComPer", detail.PComPer);

			parameters.Add("Pcs", detail.Pcs);
			parameters.Add("MemoIn", detail.MemoIn);
			parameters.Add("MTrnNo", detail.MTrnNo);
			parameters.Add("MSrNo", detail.MSrNo);
			parameters.Add("MAcYear", detail.MAcYear);
			parameters.Add("TrnTime", request.TrnTime);
			parameters.Add("SPkt", detail.SPkt);
			parameters.Add("AvgRate", detail.AvgRate);

					
			parameters.Add("CompName", request.CompName);
			parameters.Add("CDate", request.CDate);
			parameters.Add("CTime", request.CTime);			
			parameters.Add("LUser", request.Luser);

			

			parameters.Add("IsChg", request.IsChg);
			parameters.Add("ParPid", detail.ParPid);			
			parameters.Add("Descr", detail.Desc1);
			parameters.Add("OPer", request.Oper);

			parameters.Add("OrgAvgRate", detail.AvgRate > 0 ? detail.AvgRate : detail.OrgAvgRate);

			parameters.Add("PG_Code", detail.PG_Code);

			parameters.Add("VatPer", detail.VatPer);
			parameters.Add("VatAmt", detail.VatAmt);
			parameters.Add("ForDesc", detail.ForDesc);
			
			parameters.Add("@Out", dbType: DbType.Int32, direction: ParameterDirection.Output);

			await _dRepository.ExecuteAsyncQuery("SP_PurEntPBillLSave", parameters);

			var result = parameters.Get<int>("@Out");			
			if (result == 0) return result;
			if (result == 1) return 1;
			if (result == 2) return 2;
			if (result == 3) return 3;
			if (result == 999) return 999;
			return result;
		}
		public async Task<int> SaveDet(SavePurchaseRequestDto pBillHDto)
		{
			//var pBillLDtos = GenerateDetailsFromHeader(pBillHDto);
			foreach (var pBillLDto in pBillHDto.PurchaseEntryDetails)
			{
				var result = await SaveAssignDet(pBillHDto, pBillLDto);
				if (result != 0)
				{
					return result;
				}
			}

			// implementation is pending for this method

			//AddNavRec(pBillHDto);

			return 0;
		}
		public async void SaveDetPktEnt(SavePurchaseRequestDto packetInputs)
		{
			foreach (var pBillLDto in packetInputs.PurchaseEntryDetails)
			{
				if (string.IsNullOrWhiteSpace(pBillLDto.PId)) continue;

				var packet = new PktMastDto
				{
					PId = pBillLDto.PId,
					Comp_Code = packetInputs.Comp_Code,
					ParPId = pBillLDto.ParPid,
				};
				if (packetInputs.Oper == "D")
				{
					packet.S_Code = pBillLDto.S_Code;
					packet.Q_Code = (short?)pBillLDto.Q_Code;
					packet.C_Code = (short?)pBillLDto.C_Code;
					packet.SZ_Code = (short?)pBillLDto.SZ_Code;
					packet.Carat = (decimal)pBillLDto.S_Carat;
					packet.Rate = (decimal)pBillLDto.SRate;
					packet.Rap = (decimal)pBillLDto.SRate;
					packet.Descr = pBillLDto.Desc1;
				}
				else if (packetInputs.Oper == "J")
				{
					packet.Carat = (decimal)pBillLDto.S_Carat;
					packet.Rate = (decimal)pBillLDto.SRate;
					packet.I_Code = pBillLDto.I_Code;
					packet.D_Code = pBillLDto.D_Code;

					//pending implementation

					//BusLib.Master.BODesgMast ObjDesgMast = new BusLib.Master.BODesgMast();
					//clsDesgMast clsDesgMast = new clsDesgMast();
					//clsDesgMast.D_Code = clsPacketEnt.D_Code;
					//clsDesgMast.D_Name = clsPacketEnt.D_Code;
					//ObjDesgMast.SaveSingRec(clsDesgMast);
					//BOMast.DesgMast.Fill();

					//
				}
				else
				{
					packet.Carat = (decimal)pBillLDto.S_Carat;
					packet.Rate = (decimal)pBillLDto.SRate;
					packet.SN_Code = pBillLDto.SN_Code;
				}
				packet.SPkt = (short)pBillLDto.SPkt;
				await SavePacketEnt(packet, packetInputs.Oper);
			}
		}
		private async Task SavePacketEnt(PktMastDto packetInputs, string pStrOper)
		{
			int intPktStatus;
			intPktStatus = await _packetEnt.PacketExists(packetInputs.PId, packetInputs.Comp_Code);

			if (intPktStatus != 0)
			{
				return;
			}
			var packet = new PktMastDto();	
			packet.PId = packetInputs.PId;
			packet.Comp_Code = packetInputs.Comp_Code;

			if (pStrOper == "D")
			{
				packet.C_Code = packetInputs.C_Code;
				packet.S_Code = packetInputs.S_Code;
				packet.Q_Code = packetInputs.Q_Code;
				packet.SZ_Code = packetInputs.SZ_Code;
				packet.Rate = packetInputs.Rate;
				packet.Rap = packetInputs.Rate;
				packet.Diameter = 0;
				packet.Carat = packetInputs.Carat;
			}
			else if (pStrOper == "J")
			{
				packet.C_Code = 0;
				packet.S_Code = "";
				packet.Q_Code = 0;
				packet.Rate = packetInputs.Rate;
				packet.Diameter = 0;
				packet.Carat = packetInputs.Carat;
			}
			else
			{
				packet.C_Code = 0;
				packet.S_Code = "";
				packet.Q_Code = 0;
				packet.Rate = packetInputs.Rate;
				packet.Diameter = 0;
				packet.Carat = packetInputs.Carat;
			}
			packet.CT_Code = 0;
			packet.Sy_Code = 0;
			packet.Po_Code = 0;
			packet.FL_Code = 0;
			packet.Per = 0;
			packet.TIN_Code = 0;
			packet.SIN_Code = 0;
			packet.BIN_Code = 0;
			packet.SBIN_Code = 0;
			packet.OIN_Code = 0;
			packet.SOIN_Code = 0;
			packet.LU_Code = 0;
			packet.EF_Code = 0;
			packet.RIN_Code = 0;
			packet.CU_Code = 0;
			packet.BRN_Code = 0;
			packet.CR_Code = 0;
			packet.HA_Code = 0;
			packet.CertNo = "";
			packet.Descr = packetInputs.Descr;

			packet.TotDepth = 0;
			packet.Table1 = 0;
			packet.Girdle = 0;
			packet.CAngle = 0;
			packet.CHeight = 0;
			packet.PAngle = 0;
			packet.PHeight = 0;
			packet.Height = 0;
			packet.Width = 0;
			packet.Length = 0;
			packet.Ratio = 0;
			packet.SPkt = packetInputs.SPkt;

			packet.SN_Code = packetInputs.SN_Code;
			packet.BRO_Code = "";
			packet.I_Code = packetInputs.I_Code;
			packet.D_Code = packetInputs.D_Code;

			packet.Oper = packetInputs.Oper;
			//clsPacketEnt.SZ_Code = 0;

			packet.Margin = 0;
			packet.CnCy = "";
			packet.Conv = 0;
			packet.CurCost = 0;
			packet.AvgCost = 0;

			packet.SRate = 0;
			packet.SRateMin = 0;
			packet.CrtMin = 0;
			packet.CrtMax = 0;
			packet.SalCurSym = "";
			packet.Quan = 0;
			packet.GR_CodeK = 0;
			packet.GR_CodeN = 0;
			packet.RFIDTag = string.Empty;

			packet.ParPId = packetInputs.ParPId;

			await _packetEnt.AddPacketEnt(packet);
		}
		public List<PBillLDto> GetPBillLData(PBillHDto pBillHDto)
		{			
			return new List<PBillLDto>
			{
				new PBillLDto
				{
					TrnNo = (int)pBillHDto.TrnNo,
					AcYear = pBillHDto.AcYear,
					Comp_Code = pBillHDto.Comp_Code,			
					TrnDate = pBillHDto.TrnDate,
					S_Code = "0",
				}
			};
		}
		public List<PBillLDto> GenerateDetailsFromHeader(PBillHDto pBillHDto)
		{
			var details = new List<PBillLDto>();

			var detail = new PBillLDto
			{
				TrnNo = (int)pBillHDto.TrnNo,
				SrNo = 1,
				AcYear = pBillHDto.AcYear,
				Comp_Code = pBillHDto.Comp_Code,
				TrnDate = pBillHDto.TrnDate,
				Conv = pBillHDto.Conv,				
				CnCy = pBillHDto.CnCy,
				S_Carat = pBillHDto.S_Carat,
				Br_Code = pBillHDto.Br_Code,
				Brper = pBillHDto.Brper,
				Bramount = pBillHDto.Bramount,
				Lp1 = pBillHDto.Lp1,
				Lt1 = pBillHDto.Lt1,
				Lp2 = pBillHDto.Lp2,
				Lt2 = pBillHDto.Lt2,
				Stype = pBillHDto.Stype,
				Otype = pBillHDto.Otype,
				Pdis = pBillHDto.Pdis,
				Pcom = pBillHDto.Pcom,
				TrnTime = pBillHDto.TrnTime,
				Amount = pBillHDto.Amount,
				Gamount = pBillHDto.Gamount,
				Rem = pBillHDto.Remark,
				Pid = pBillHDto.PId,
				AvgRate = pBillHDto.AvgRate,
				OrgAvgRate = pBillHDto.OrgAvgRate,
				//not save in db fields

				S_Code = pBillHDto.S_Code,
				Q_Code = pBillHDto.Q_Code,
				C_Code = pBillHDto.C_Code,
				Sz_Code = pBillHDto.Sz_Code,
				
				Srate = pBillHDto.Srate,
				Desc1 = pBillHDto.Desc1,
			};

			details.Add(detail);
			return details;
		}
	}
}


