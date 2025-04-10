using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Interfaces.IMaster
{
	public interface IColMastRepository
	{
		Task<List<ColMastDto>> GetAllColours();
		Task<int> AddColour(ColMastDto colMast);
		Task<int> UpdateColour(ColMastDto colMast);
		Task<int> DeleteColour(short C_Code);
	}
}
