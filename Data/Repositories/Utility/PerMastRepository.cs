using Acc.Data.Interfaces.IUtility;
using Acc.Data.Repository.Interface;
using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Repositories.Utility
{
	public class PerMastRepository : IPerMastRepository
	{
		private readonly IDRepository _dRepository;

		public PerMastRepository(IDRepository dRepository)
		{
			_dRepository = dRepository;
		}
		public async Task<List<PerMastDto>> GetAllPerMast(string User_Name)
		{
			return await _dRepository.GetAll<PerMastDto>("SP_UtilFrmPerMast",new {User_Name});
		}
		public async Task<List<PerMastDto>> GetUserWiseMenu(string User_Name)
		{
			return await _dRepository.GetAll<PerMastDto>("SP_GetUserWiseMenu", new { User_Name });
		}
		public async Task<int> AddPerMast(PerMastDto perMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_PerMastSave", perMast);
		}
		public async Task<int> UpdatePerMast(PerMastDto perMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_PerMastSave", perMast);
		}
		public async Task<int> DeletePerMast(string USER_NAME,string FORM_NAME)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_PerMastDel", new { USER_NAME , FORM_NAME });
		}
	}
}
