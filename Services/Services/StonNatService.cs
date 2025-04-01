using Acc.Data.Interfaces;
using Acc.Services.Interfaces;
using Acc.Shared.Dtos;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Services
{
	public class StonNatService : IStonNatService
	{
		private readonly IStonNatRepository _stonNat;

		public StonNatService(IStonNatRepository stonNat)
		{
			_stonNat = stonNat;
		}
		public async Task<List<StonNatDto>> GetAllStone()
		{
			return await _stonNat.GetAllStone();
		}
		public async Task<int> AddStone(StonNatDto stonNat)
		{
			return await _stonNat.AddStone(stonNat);
		}
		public async Task<int> UpdateStone(StonNatDto stonNat)
		{
			return await _stonNat.UpdateStone(stonNat);
		}
		public async Task<int> DeleteStone(string SN_Code)
		{
			return await _stonNat.DeleteStone(SN_Code);
		}
	}
}
