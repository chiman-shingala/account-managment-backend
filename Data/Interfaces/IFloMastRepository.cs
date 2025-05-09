using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Interfaces
{
	public interface IFloMastRepository
	{
		Task<List<FloMastDto>> GetAllFloMast();
		Task<int> AddFloMast(FloMastDto floMastDto);
		Task<int> UpdateFloMast(FloMastDto floMastDto);
		Task<int> DeleteDesgMast(string FL_Code);
	}
}
