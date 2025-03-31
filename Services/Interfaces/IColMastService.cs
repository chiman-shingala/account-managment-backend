using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Interfaces
{
	public interface IColMastService
	{
		Task<List<ColMastDto>> GetAllColours();
		Task<int> AddColour(ColMastDto colMast);
		Task<int> UpdateColour(ColMastDto colMast);
		Task<int> DeleteColour(short cCode);
	}
}
