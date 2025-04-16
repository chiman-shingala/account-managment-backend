using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Interfaces.Price_Para
{
	public interface ISIncMastService
	{
		Task<List<SIncMastDto>> GetAllSIncMast();
		Task<int> AddSIncMast(SIncMastDto sbincMast);
		Task<int> UpdateSIncMast(SIncMastDto sbincMast);
		Task<int> DeleteSIncMast(short SIN_Code);
	}
}
