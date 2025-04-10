using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Interfaces.Master
{
	public interface IParPktMastService
	{
		Task<List<ParPktMastDto>> GetAllParPktMast();
		Task<int> AddParPktMast(ParPktMastDto parPktMast);
		Task<int> UpdateParPktMast(ParPktMastDto parPktMast);
		Task<int> DeleteParPktMast(string ParPId, string Comp_Code);
	}
}
