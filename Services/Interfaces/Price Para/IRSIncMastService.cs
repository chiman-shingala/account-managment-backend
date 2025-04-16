using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Interfaces.Price_Para
{
	public interface IRSIncMastService
	{
		Task<List<RsincMastDto>> GetAllRSIncMast();
		Task<int> AddRSIncMast(RsincMastDto rsincMast);
		Task<int> UpdateRSIncMast(RsincMastDto rsincMast);
		Task<int> DeleteRSIncMast(short RSIN_Code);
	}
}
