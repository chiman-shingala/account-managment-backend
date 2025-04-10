using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Interfaces.IMaster
{
	public interface IDeptMastRepository
	{
		Task<List<DeptMastDto>> GetAllDeptMast();
		Task<int> AddDeptMast(DeptMastDto deptMast);
		Task<int> UpdateDeptMast(DeptMastDto deptMast);
		Task<int> DeleteDeptMast(string DP_Code);
	}
}
