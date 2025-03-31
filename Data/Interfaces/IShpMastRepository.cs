using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Interfaces
{
	public interface IShpMastRepository
	{
		Task<List<ShpMastDto>> GetAllShape();
		Task<int> AddShape(ShpMastDto shpMast);
		Task<int> UpdateShape(ShpMastDto shpMast);
		Task<int> DeletePurity(string Q_Code);
	}
}
