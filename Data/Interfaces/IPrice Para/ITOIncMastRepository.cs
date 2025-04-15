using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Interfaces
{
	public interface ITOIncMastRepository
	{
		Task<string?> GetTOIncPer(int pintTOIncCode);
		Task<List<TOIncMastDto>> GetAllTOIncMast();
		Task<int> AddTOIncMast(TOIncMastDto tOIncMast);
		Task<int> UpdateTOIncMast(TOIncMastDto tOIncMast);
		Task<int> DeleteTOIncMast(short ToincCode);
	}
}
