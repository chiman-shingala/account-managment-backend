using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Interfaces.IRapaport
{
	public interface ICutDiscRepository
	{
		Task<List<CutDiscDto>> GetAllCutDisc(int SZ_Code, string S_Code, int CT_Code);
		Task<int> AddCutDisc(InsertCutDiscDto cutDiscDto);
		Task<int> UpdateCutDisc(InsertCutDiscDto cutDiscDto);
		Task<int> DeleteCutDisc(short C_CODE, short SZ_Code, string S_Code, int CT_Code);
	}
}
