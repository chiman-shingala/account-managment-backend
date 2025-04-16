using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Interfaces
{
	public interface IEFacMastRepository
	{
		Task<string?> GetEFacPer(int pintEFCode);

		Task<List<EfacMastDto>> GetAllEFacMast();
		Task<int> AddEFacMast(EfacMastDto efacMast);
		Task<int> UpdateEFacMast(EfacMastDto efacMast);
		Task<int> DeleteEFacMast(short EF_Code);
	}
}
