using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Interfaces.Master
{
	public interface IShpMastService
	{
		Task<List<ShpMastDto>> GetAllShape();
		Task<int> AddShape(ShpMastDto shpMast);
		Task<int> UpdateShape(ShpMastDto shpMast);
		Task<int> DeleteShape(string S_Code);
	}
}
