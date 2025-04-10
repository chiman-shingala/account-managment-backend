using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Interfaces.Master
{
	public interface IPCompMastService
	{
		Task<int> AddPCompMast(PCompMastDto pCompMast);
		Task<int> UpdatePCompMast(PCompMastDto pCompMast);
		Task<int> DeletePCompMast(string P_Code, int Acyear, string Comp_Code);

	}
}
