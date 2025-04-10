using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Interfaces.Rapaport
{
	public interface IFluoDiscService
	{
		Task<List<FluoDiscDto>> GetAllFluoDisc(int SZ_Code, string S_Code, int FL_Code);
		Task<int> AddFluoDisc(InsertFluoDiscDto fluoDiscDto);
		Task<int> UpdateCutDisc(InsertFluoDiscDto fluoDiscDto);
		Task<int> DeleteCutDisc(short C_Code, short SZ_Code, string S_Code, int FL_Code);
	}
}
