using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Interfaces.Price_Para
{
	public interface ITOIncMastService
	{
		Task<List<TOIncMastDto>> GetAllTOIncMast();
		Task<int> AddTOIncMast(TOIncMastDto tOIncMast);
		Task<int> UpdateTOIncMast(TOIncMastDto tOIncMast);
		Task<int> DeleteTIncMast(short TOIN_Code);
	}
}
