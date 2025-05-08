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
	public class ParPktMastRepository : IParPktMastRepository
	{
		private readonly IDRepository _dRepository;

		public ParPktMastRepository(IDRepository dRepository)
		{
			_dRepository = dRepository;
		}
		public async Task<List<ParPktMastDto>> GetAllParPktMast(string Comp_Code)
		{
			return await _dRepository.GetAll<ParPktMastDto>("SP_MastParPktMastFill",new { Comp_Code });
		}
		public async Task<int> AddParPktMast(ParPktMastDto ParPktMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_ParPktMastSave", ParPktMast);
		}
		public async Task<int> UpdateParPktMast(ParPktMastDto ParPktMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_ParPktMastSave", ParPktMast);
		}
		public async Task<int> DeleteParPktMast(string ParPId,string Comp_Code)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_UtilParPktMastDel", new { ParPId,Comp_Code });
		}
	}
}
