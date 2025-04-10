using Acc.Data.Interfaces.IMaster;
using Acc.Data.Repository.Interface;
using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Repositories.Master
{
	public class DeptMastRepository : IDeptMastRepository
	{
		private readonly IDRepository _dRepository;

		public DeptMastRepository(IDRepository dRepository)
		{
			_dRepository = dRepository;
		}
		public async Task<List<DeptMastDto>> GetAllDeptMast()
		{
			return await _dRepository.GetAll<DeptMastDto>("SP_MastDeptMastFill");
		}
		public async Task<int> AddDeptMast(DeptMastDto deptMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_DeptMastSave", deptMast);
		}
		public async Task<int> UpdateDeptMast(DeptMastDto deptMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_DeptMastSave", deptMast);
		}
		public async Task<int> DeleteDeptMast(string DP_Code)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_UtilDeptMastDel", new { DP_Code });
		}
	}
}
