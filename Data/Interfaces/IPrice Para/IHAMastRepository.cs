using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Interfaces
{
	public interface IHAMastRepository
	{
		Task<string?> GetHAPer(int pintHAIncCode);
		Task<List<HAMastDto>> GetAllHAMast();
		Task<int> AddHAMast(HAMastDto hAMast);
		Task<int> UpdateHAMast(HAMastDto hAMast);
		Task<int> DeleteHAMast(short HA_Code);
	}
}
