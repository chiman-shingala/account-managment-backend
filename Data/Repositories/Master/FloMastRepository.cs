using Acc.Data.Interfaces;
using Acc.Data.Repository.Interface;
using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Repositories.Master
{
	public class FloMastRepository : IFloMastRepository
	{
		private readonly IDRepository _dRepository;

		public FloMastRepository(IDRepository dRepository)
		{
			_dRepository = dRepository;
		}
		public async Task<List<FloMastDto>> GetAllFloMast()
		{
			return await _dRepository.GetAll<FloMastDto>("SP_MastFLoMastFill");
		}
		public async Task<int> AddFloMast(FloMastDto floMastDto)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_FLoMastSave", floMastDto);
		}
		public async Task<int> UpdateFloMast(FloMastDto floMastDto)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_FLoMastSave", floMastDto);
		}
		public async Task<int> DeleteDesgMast(string FL_Code)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_UtilFloMastDel", new { FL_Code });
		}
	}
}
