using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Interfaces.Master
{
	public interface IDeptMastService
	{
		Task<List<DeptMastDto>> GetAllDeptMast();
		Task<int> AddDept(DeptMastDto deptMast);
		Task<int> UpdateDept(DeptMastDto deptMast);
		Task<int> DeleteDept(string DP_Code);
		
	}
}
