using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Interfaces
{
	public interface IGrpMastService
	{
		Task<List<GrpMastDto>> GetAllGrp();
		Task<int> AddGrp(GrpMastDto grpMast);
		Task<int> UpdateGrp(GrpMastDto grpMast);
		Task<int> DeleteGrp(string GR_Code);
	}
}
