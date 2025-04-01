using Acc.Data.Interfaces;
using Acc.Data.Repository.Interface;
using Acc.Shared.Dtos;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Repositories
{
	public class PCompMastRepository :IPCompMastRepository
	{
		private readonly IDRepository _dRepository;

		public PCompMastRepository(IDRepository dRepository)
		{
			_dRepository = dRepository;
		}
		//public async Task<List<GrpMastDto>> GetAllGroup()
		//{
		//	return await _dRepository.GetAll<GrpMastDto>("SP_MastGrpMastFill");
		//}
		public async Task<int> AddPCompMast(PCompMastDto pCompMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_PCompMastCompSave", pCompMast);
		}
		public async Task<int> UpdatePCompMast(PCompMastDto pCompMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_PCompMastCompSave", pCompMast);
		}
		public async Task<int> DeletePCompMast(string P_Code, int Acyear, string Comp_Code)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_PCompMastDel", new { P_Code,Acyear,Comp_Code });
		}
	}
}
