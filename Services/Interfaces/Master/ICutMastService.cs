using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Interfaces.Master
{
	public interface ICutMastService
	{
		Task<List<CutMastDto>> GetAllCuts();
		Task<int> AddCut(CutMastDto cutMast);
		Task<int> UpdateCut(CutMastDto cutMast);
		Task<int> DeleteCut(short CT_Code);
	}
}
