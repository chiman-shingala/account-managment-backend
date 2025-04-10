using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Interfaces.Master
{
	public interface IStonNatService
	{
		Task<List<StonNatDto>> GetAllStone();
		Task<int> AddStone(StonNatDto stonNat);
		Task<int> UpdateStone(StonNatDto stonNat);
		Task<int> DeleteStone(string SN_Code);
	}
}
