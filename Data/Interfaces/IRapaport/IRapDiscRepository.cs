using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Interfaces.IRapaport
{
	public interface IRapDiscRepository
	{
		Task<List<RapDiscDto>> GetAllRapDisc(int SZ_Code, string S_Code);
		Task<int> AddRapDisc(InsertRapDiscDto itemMast);
		Task<int> UpdateRapDisc(InsertRapDiscDto itemMast);
		Task<int> DeleteRapDisc(short C_CODE, short SZ_Code, string S_Code);
	}
}
