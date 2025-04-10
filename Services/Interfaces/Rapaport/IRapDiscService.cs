using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Interfaces.Rapaport
{
	public interface IRapDiscService
	{
		Task<List<RapDiscDto>> GetAllRapDisc(int SZ_Code, string S_Code);
		Task<int> AddRapDisc(InsertRapDiscDto RapDiscDto);
		Task<int> UpdateRapDisc(InsertRapDiscDto RapDiscDto);
		Task<int> DeleteRapDisc(short C_Code, short SZ_Code, string S_Code);
	}
}
