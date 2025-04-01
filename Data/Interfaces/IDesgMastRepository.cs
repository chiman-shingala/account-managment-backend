using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Interfaces
{
	public interface IDesgMastRepository
	{
		Task<List<DesgMastDto>> GetAllDesgMast();
		Task<int> AddDesgMast(DesgMastDto desgMast);
		Task<int> UpdateDesgMast(DesgMastDto desgMast);
		Task<int> DeleteDesgMast(string D_Code);
	}
}
