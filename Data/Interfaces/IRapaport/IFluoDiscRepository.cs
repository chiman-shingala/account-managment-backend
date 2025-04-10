using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Interfaces.IRapaport
{
	public interface IFluoDiscRepository
	{
		Task<List<FluoDiscDto>> GetAllFluoDisc(int SZ_Code, string S_Code, int FL_Code);
		Task<int> AddFluoDisc(InsertFluoDiscDto fluoDiscDto);
		Task<int> UpdateFluoDisc(InsertFluoDiscDto fluoDiscDto);
		Task<int> DeleteFluoDisc(short C_CODE, short SZ_Code, string S_Code, int FL_Code);
	}
}
