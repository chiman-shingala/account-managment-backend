using Acc.Data.Interfaces;
using Acc.Data.Interfaces.IMaster;
using Acc.Data.Interfaces.IRapaport;
using Acc.Data.Interfaces.ITransaction;
using Acc.Services.Interfaces.Transaction;
using Acc.Shared.Dtos;
using Val = Acc.Shared.Common.CommonMethods;

namespace Acc.Services.Services.Transaction
{
	public class PacketEntService : IPacketEntService
	{
		private readonly IRapaportRepository _rapaportRepo;
		private readonly ISizeMastRepository _sizeMastRepository;
		private readonly IBrnMastRepository _brnMastRepository;
		private readonly ICulMastRepository _culMastRepository;
		private readonly IEFacMastRepository _eFacMastRepository;
		private readonly ILustMastRepository _lustMastRepository;
		private readonly IRSIncMastRepository _rSIncMastRepository;
		private readonly ISBIncMastRepository _sBIncMastRepository;
		private readonly ISIncMastRepository _sIncMastRepository;
		private readonly ISOIncMastRepository _sOIncMastRepository;
		private readonly ITBIncMastRepository _tBIncMastRepository;
		private readonly ITIncMastRepository _tIncMastRepository;
		private readonly ITOIncMastRepository _tOIncMastRepository;
		private readonly IHAMastRepository _hAMastRepository;
		private readonly IPacketEntRepository _packetEntRepository;

		public PacketEntService(IRapaportRepository rapaportRepo, ISizeMastRepository sizeMastRepository,
			IBrnMastRepository brnMastRepository, ICulMastRepository culMastRepository,
			IEFacMastRepository eFacMastRepository, ILustMastRepository lustMastRepository,
			IRSIncMastRepository rSIncMastRepository, ISBIncMastRepository sBIncMastRepository,
			ISIncMastRepository sIncMastRepository, ISOIncMastRepository sOIncMastRepository,
			ITBIncMastRepository tBIncMastRepository, ITIncMastRepository tIncMastRepository,
			ITOIncMastRepository tOIncMastRepository, IHAMastRepository hAMastRepository,
			IPacketEntRepository packetEntRepository)
		{
			_rapaportRepo = rapaportRepo;
			_sizeMastRepository = sizeMastRepository;
			_brnMastRepository = brnMastRepository;
			_culMastRepository = culMastRepository;
			_eFacMastRepository = eFacMastRepository;
			_lustMastRepository = lustMastRepository;
			_rSIncMastRepository = rSIncMastRepository;
			_sBIncMastRepository = sBIncMastRepository;
			_sIncMastRepository = sIncMastRepository;
			_sOIncMastRepository = sOIncMastRepository;
			_tBIncMastRepository = tBIncMastRepository;
			_tIncMastRepository = tIncMastRepository;
			_tOIncMastRepository = tOIncMastRepository;
			_hAMastRepository = hAMastRepository;
			_packetEntRepository = packetEntRepository;
		}
		public async Task<double> FindRapAsync(PacketEntDto pc1)
		{
			double doubrap = 0;
			int sizeCode = _sizeMastRepository.GetSizeCode(pc1.Carat).Result;

			if (!string.IsNullOrWhiteSpace(pc1.S_Code) && pc1.Q_Code != 0 && pc1.C_Code != 0 && pc1.Carat != 0 && sizeCode != 0)
			{
				doubrap = await _rapaportRepo.FindRap(pc1.S_Code, pc1.Q_Code, pc1.C_Code, sizeCode);
			}
			return doubrap;
		}
		public async Task<double> FindRapDisc(PacketEntDto pc1)
		{
			double doubrap = 0;
			int sizeCode = _sizeMastRepository.GetSizeCode(pc1.Carat).Result;

			if (!string.IsNullOrWhiteSpace(pc1.S_Code) && pc1.Q_Code != 0 && pc1.C_Code != 0 && pc1.Carat != 0 && sizeCode != 0)
			{
				doubrap = await _rapaportRepo.FindDisc(pc1.S_Code, pc1.Q_Code, pc1.C_Code, sizeCode);
			}
			return doubrap;
		}
		public async Task<double> FindRap(string shapeCode, int colorCode, int qualityCode, double carat)
		{
			var packet = new PacketEntDto
			{
				S_Code = shapeCode,
				C_Code = colorCode,
				Q_Code = qualityCode,
				Carat = carat
			};
			return await FindRapAsync(packet);
		}
		public async Task<double> FindRapDisc(string shapeCode, int colorCode, int qualityCode, double carat)
		{
			var packet = new PacketEntDto
			{
				S_Code = shapeCode,
				C_Code = colorCode,
				Q_Code = qualityCode,
				Carat = carat
			};
			return await FindRapDisc(packet);
		}
		public async Task<double> FindFluoDisc(PacketEntDto pc1)
		{
			double doubrap = 0;
			int sizeCode = _sizeMastRepository.GetSizeCode(pc1.Carat).Result;

			if (!string.IsNullOrWhiteSpace(pc1.S_Code) && pc1.Q_Code != 0 && pc1.C_Code != 0 && pc1.Carat != 0 && sizeCode != 0 && pc1.FL_Code != 0)
			{
				doubrap = await _rapaportRepo.FindFluoDisc(pc1.S_Code, pc1.Q_Code, pc1.C_Code, sizeCode, pc1.FL_Code);
			}
			return doubrap;
		}
		public async Task<double> FindFluoDisc(string s_Code, int c_Code, int q_Code, double carat, int FL_Code)
		{
			var packet = new PacketEntDto
			{
				S_Code = s_Code,
				C_Code = c_Code,
				Q_Code = q_Code,
				Carat = carat,
				FL_Code = FL_Code
			};
			return await FindFluoDisc(packet);
		}
		public async Task<double> FindCutDisc(PacketEntDto pc1)
		{
			double doubrap = 0;
			int sizeCode = _sizeMastRepository.GetSizeCode(pc1.Carat).Result;

			if (!string.IsNullOrWhiteSpace(pc1.S_Code) && pc1.Q_Code != 0 && pc1.C_Code != 0 && pc1.Carat != 0 && sizeCode != 0 && pc1.CT_Code != 0)
			{
				doubrap = await _rapaportRepo.FindCutDisc(pc1.S_Code, pc1.Q_Code, pc1.C_Code, sizeCode, pc1.CT_Code);
			}
			return doubrap;
		}
		public async Task<double> FindCutDisc(string s_Code, int c_Code, int q_Code, double carat, int CT_Code)
		{
			var packet = new PacketEntDto
			{
				S_Code = s_Code,
				C_Code = c_Code,
				Q_Code = q_Code,
				Carat = carat,
				CT_Code = CT_Code
			};
			return await FindCutDisc(packet);
		}
		public async Task<RapDiscDetDto> GetRapDetailsAsync(PacketEntDto packet, RapDetailInputDto rapDetail, bool returnDetail = true)
		{
			double dblRate = 0;
			double dblRap = await FindRapAsync(packet);
			double dblDiscPer = await FindRapDisc(packet);
			double dblFloPer = await FindFluoDisc(packet);
			double dblCutPer = await FindCutDisc(packet);

			double dblBrnPer = Val.ToDouble(await _brnMastRepository.GetBrnPer(rapDetail.BrnCode) ?? "0");
			double dblCulPer = Val.ToDouble(await _culMastRepository.GetCulPer(rapDetail.CulCode) ?? "0");
			double dblEFacPer = Val.ToDouble(await _eFacMastRepository.GetEFacPer(rapDetail.EFacCode) ?? "0");
			double dblLustPer = Val.ToDouble(await _lustMastRepository.GetLustPer(rapDetail.LustCode) ?? "0");
			double dblRSIncPer = Val.ToDouble(await _rSIncMastRepository.GetRSIncPer(rapDetail.RSIncCode) ?? "0");

			double dblSBIncPer = Val.ToDouble(await _sBIncMastRepository.GetSBIncPer(rapDetail.SBIncCode) ?? "0");
			double dblSIncPer = Val.ToDouble(await _sIncMastRepository.GetSIncPer(rapDetail.SIncCode) ?? "0");
			double dblSOIncPer = Val.ToDouble(await _sOIncMastRepository.GetSOIncPer(rapDetail.SOIncCode) ?? "0");
			double dblTBIncPer = Val.ToDouble(await _tBIncMastRepository.GetTBIncPer(rapDetail.TBIncCode) ?? "0");
			double dblTIncPer = Val.ToDouble(await _tIncMastRepository.GetTIncPer(rapDetail.TIncCode) ?? "0");
			double dblTOIncPer = Val.ToDouble(await _tOIncMastRepository.GetTOIncPer(rapDetail.TOIncCode) ?? "0");

			double dblHAPer = Val.ToDouble(await _hAMastRepository.GetHAPer(rapDetail.HACode) ?? "0");

			double dblPerTot = dblDiscPer + dblFloPer + dblCutPer + dblBrnPer + dblCulPer +
					   dblEFacPer + dblLustPer + dblRSIncPer + dblSBIncPer +
					   dblSIncPer + dblSOIncPer + dblTBIncPer + dblTIncPer +
					   dblTOIncPer + dblHAPer;

			if (dblRap * dblPerTot == 0)
			{
				dblRate = dblRap;
			}
			else
			{
				dblRate = dblRap - (dblRap - dblPerTot / 100);
			}
			if (returnDetail)
			{
				return new RapDiscDetDto
				{
					DiscPer = dblDiscPer,
					FloPer = dblFloPer,
					CutPer = dblCutPer,
					BrnPer = dblBrnPer,
					CulPer = dblCulPer,
					EFacPer = dblEFacPer,
					LustPer = dblLustPer,
					RSIncPer = dblRSIncPer,
					SBIncPer = dblSBIncPer,
					SIncPer = dblSIncPer,
					SOIncPer = dblSOIncPer,
					TBIncPer = dblTBIncPer,
					TIncPer = dblTIncPer,
					TOIncPer = dblTOIncPer,
					HAPer = dblHAPer,
					PerTot = dblPerTot,
					FinalRate = dblRate,
					RapPrice = dblRap
				};
			}
			return null;
		}		
		public async Task<int> AddPacketEnt(PktMastDto packetEnt)
		{
			return await _packetEntRepository.AddPacketEnt(packetEnt);
		}
		public async Task<int> UpdatePacketEnt(PktMastDto packetEnt)
		{
			return await _packetEntRepository.UpdatePacketEnt(packetEnt);
		}
		public async Task<int> DeletePacketEnt(string PId,string Comp_Code)
		{
			return await _packetEntRepository.DeletePacketEnt(PId, Comp_Code);
		}
	}
}
