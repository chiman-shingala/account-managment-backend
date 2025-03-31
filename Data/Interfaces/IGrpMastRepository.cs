using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Interfaces
{
	public interface IGrpMastRepository
	{
		Task<List<GrpMastDto>> GetAllGroup();
		Task<int> AddGroup(GrpMastDto grpMast);
		Task<int> UpdateGroup(GrpMastDto grpMast);
		Task<int> DeleteGroup(string Gr_Code);
	}
}
