using Acc.Data.Interfaces;
using Acc.Services.Interfaces;
using Acc.Shared.Dtos;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Services
{
	public class DeptMastService : IDeptMastService
	{
		private readonly IDeptMastRepository _deptMast;

		public DeptMastService(IDeptMastRepository deptMast)
		{
			_deptMast = deptMast;
		}
		public async Task<List<DeptMastDto>> GetAllDeptMast()
		{
			return await _deptMast.GetAllDeptMast();
		}
		public async Task<int> AddDept(DeptMastDto deptMast)
		{
			return await _deptMast.AddDeptMast(deptMast);
		}
		public async Task<int> UpdateDept(DeptMastDto deptMast)
		{
			return await _deptMast.UpdateDeptMast(deptMast);
		}
		public async Task<int> DeleteDept(string DP_Code)
		{
			return await _deptMast.DeleteDeptMast(DP_Code);
		}
	}
}
