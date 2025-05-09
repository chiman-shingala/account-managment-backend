using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Interfaces.Master
{
	public interface IFloMastService
	{
		Task<List<FloMastDto>> GetAllFloMast();
		Task<int> AddFloMast(FloMastDto floMastDto);
		Task<int> UpdateFloMast(FloMastDto floMastDto);
		Task<int> DeleteFloMast(string FL_Code);
	}
}
