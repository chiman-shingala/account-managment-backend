using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Interfaces.Master
{
	public interface IParMastService
	{
		Task<List<ParMastDto>> GetAllParMast(ParMastFillDto parMastFill);
		Task<int> AddParMast(ParMastDto parMast);
		Task<int> UpdateParMast(ParMastDto parMast);
		Task<int> DeleteParMast(string P_Code, int Acyear, string Comp_Code);
	}
}
