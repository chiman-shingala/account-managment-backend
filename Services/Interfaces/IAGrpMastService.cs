using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Interfaces
{
	public interface IAGrpMastService
	{
		Task<List<AGrpMastDto>> GetAllAGrp();
		Task<int> AddAGrp(AGrpMastDto aGrpMast);
		Task<int> UpdateAGrp(AGrpMastDto aGrpMast);
		Task<int> DeleteAGrp(int AGR_Code);
		Task<int> NewIdAGrpMast();
	}
}
