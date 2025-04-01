using Acc.Data.Interfaces;
using Acc.Data.Repository.Interface;
using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Repositories
{
	public class ShpMastRepository : IShpMastRepository
	{
		private readonly IDRepository _dRepository;

		public ShpMastRepository(IDRepository dRepository)
		{
			_dRepository = dRepository;
		}
		public async Task<List<ShpMastDto>> GetAllShape()
		{
			return await _dRepository.GetAll<ShpMastDto>("SP_MastShpMastFill");
		}
		public async Task<int> AddShape(ShpMastDto shpMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_ShpMastSave", shpMast);
		}
		public async Task<int> UpdateShape(ShpMastDto shpMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_ShpMastSave", shpMast);
		}
		public async Task<int> DeleteShape(string S_Code)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_UtilShpMastShpDel", new { S_Code });
		}
	}
}
