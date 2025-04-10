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
	public class DesgMastRepository : IDesgMastRepository
	{
		private readonly IDRepository _dRepository;

		public DesgMastRepository(IDRepository dRepository)
		{
			_dRepository = dRepository;
		}
		public async Task<List<DesgMastDto>> GetAllDesgMast()
		{
			return await _dRepository.GetAll<DesgMastDto>("SP_MastDesgMastFill");
		}
		public async Task<int> AddDesgMast(DesgMastDto desgMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_DesgMastSave", desgMast);
		}
		public async Task<int> UpdateDesgMast(DesgMastDto desgMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_DesgMastSave", desgMast);
		}
		public async Task<int> DeleteDesgMast(string D_Code)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_UtilDesgMastDel", new { D_Code });
		}
	}
}
