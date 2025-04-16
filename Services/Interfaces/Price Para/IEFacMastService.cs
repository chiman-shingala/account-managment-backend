using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Interfaces.Price_Para
{
	public interface IEFacMastService
	{
		Task<List<EfacMastDto>> GetAllEFacMast();
		Task<int> AddlEFacMast(EfacMastDto efacMast);
		Task<int> UpdatelEFacMast(EfacMastDto efacMast);
		Task<int> DeletelEFacMast(short EF_Code);
	}
}
