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
	public class PurityMastRepository : IPurityMastRepository
	{
		private readonly IDRepository _dRepository;

		public PurityMastRepository(IDRepository dRepository)
		{
			_dRepository = dRepository;
		}
		public async Task<List<QuaMastDto>> GetAllPurity()
		{
			return await _dRepository.GetAll<QuaMastDto>("SP_MastQuaMastFill");
		}
		public async Task<int> AddPurity(QuaMastDto quaMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_QuaMastSave", quaMast);
		}
		public async Task<int> UpdatePurity(QuaMastDto quaMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_QuaMastSave", quaMast);
		}
		public async Task<int> DeletePurity(short Q_Code)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_UtilQuaMastQuaDel", new { Q_Code });
		}
	}
}
