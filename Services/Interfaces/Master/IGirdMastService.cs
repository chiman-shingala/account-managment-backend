using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Interfaces.Master
{
	public interface IGirdMastService
	{
		Task<List<GirdMastDto>> GetAllGridMast();
		Task<int> AddGridMast(GirdMastDto girdMast);
		Task<int> UpdateGridMast(GirdMastDto girdMast);
		Task<int> DeleteGridMast(string Gr_Code);
	}
}
