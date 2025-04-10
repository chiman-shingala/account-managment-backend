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
	public class ColMastRepository : IColMastRepository
	{
		private readonly IDRepository _dRepository;

		public ColMastRepository(IDRepository dRepository )
		{
			_dRepository = dRepository;
		}
		public async Task<List<ColMastDto>> GetAllColours()
		{
			return await _dRepository.GetAll<ColMastDto>("SP_MastColMastFill");
		}
		public async Task<int> AddColour(ColMastDto colMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_ColMastSave", colMast);
		}
		public async Task<int> UpdateColour(ColMastDto colMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_ColMastSave", colMast);
		}
		public async Task<int> DeleteColour(short C_Code)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_UtilColMastColDel", new { C_Code });
		}
	}
}
