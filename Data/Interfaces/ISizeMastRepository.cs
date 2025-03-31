using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Interfaces
{
	public interface ISizeMastRepository
	{
		Task<List<SizeMastDto>> GetAllSize();
		Task<int> AddSize(SizeMastDto sizeMast);
		Task<int> UpdateSize(SizeMastDto sizeMast);
		Task<int> DeleteSize(short SZ_Code);
	}
}
