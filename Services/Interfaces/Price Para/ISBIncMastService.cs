using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Interfaces.Price_Para
{
	public interface ISBIncMastService
	{
		Task<List<SbincMastDto>> GetAllSBIncMast();
		Task<int> AddSBIncMast(SbincMastDto sbincMast);
		Task<int> UpdateSBIncMast(SbincMastDto sbincMast);
		Task<int> DeleteSIncMast(short SBIN_Code);
	}
}
