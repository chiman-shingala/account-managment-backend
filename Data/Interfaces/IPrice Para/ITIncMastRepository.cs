using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Interfaces
{
	public interface ITIncMastRepository 
	{
		Task<string?> GetTIncPer(int pintTIncCode);
		Task<List<TIncMastDto>> GetAllTIncMast();
		Task<int> AddTIncMast(TIncMastDto incMast);
		Task<int> UpdateTIncMast(TIncMastDto incMast);

		Task<int> DeleteTIncMast(short TinCode);
	}
}
