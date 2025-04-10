using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Interfaces.IMaster
{
	public interface IParPktMastRepository
	{
		Task<List<ParPktMastDto>> GetAllParPktMast();
		Task<int> AddParPktMast(ParPktMastDto ParPktMast);
		Task<int> UpdateParPktMast(ParPktMastDto ParPktMast);
		Task<int> DeleteParPktMast(string ParPId, string Comp_Code);
	}
}
