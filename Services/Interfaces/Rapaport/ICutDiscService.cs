using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Interfaces.Rapaport
{
	public interface ICutDiscService
	{
		Task<List<CutDiscDto>> GetAllCutDisc(int SZ_Code, string S_Code, int CT_Code);
		Task<int> AddCutDisc(InsertCutDiscDto cutDiscDto);
		Task<int> UpdateCutDisc(InsertCutDiscDto cutDiscDto);
		Task<int> DeleteCutDisc(short C_Code, short SZ_Code, string S_Code, int CT_Code);
	}
}
