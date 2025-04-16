using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Interfaces
{
	public interface ISBIncMastRepository
	{
		Task<string?> GetSBIncPer(int pintSBIncCode);
		Task<List<SbincMastDto>> GetAllSBIncMast();
		Task<int> AddSBIncMast(SbincMastDto sbincMastDto);
		Task<int> UpdateSBIncMast(SbincMastDto sbincMastDto);
		Task<int> DeleteSBIncMast(short SBIN_Code);
	}
}
