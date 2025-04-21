using Acc.Data.Interfaces.ITransaction;
using Acc.Data.Repository.Interface;
using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Repositories.Transaction
{
	public class PacketOpnRepository : IPacketOpnRepository
	{
		private readonly IDRepository _dRepository;

		public PacketOpnRepository(IDRepository dRepository)
		{
			_dRepository = dRepository;
		}
		public async Task<List<PacketOpnDispDto>> GetPacketOpn(string PId,string Comp_Code,string Oper,int AcYear)
		{
			return await _dRepository.GetAll<PacketOpnDispDto>("SP_PktOpnDisp", new { PId = PId, Comp_Code = Comp_Code, Oper = Oper, AcYear = AcYear });
		}
		public async Task<int> AddPacketOpn(PktOpnDto pktOpn)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_PktOpnSave",pktOpn);
		}
		public async Task<int> UpdatePacketOpn(PktOpnDto pktOpn)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_PktOpnSave", pktOpn);
		}			
	}
}
