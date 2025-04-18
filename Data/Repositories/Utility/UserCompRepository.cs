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
	public class UserCompRepository : IUserCompRepository
	{
		private readonly IDRepository _dRepository;

		public UserCompRepository(IDRepository dRepository)
		{
			_dRepository = dRepository;
		}
		public async Task<List<CompMastDto>> GetAllComp()
		{
			return await _dRepository.GetAll<CompMastDto>("SP_MastComMastFill");
		}
		public async Task<List<CompMastDto>> GetUserWiseComp(string UserId)
		{
			return await _dRepository.GetAll<CompMastDto>("SP_MastComMastFill",new {UserId});
		}
		public async Task<int> AddUserComp(UserCompDto userComp)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_UserCompSave", userComp);
		}
		public async Task<int> UpdateUserComp(UserCompDto userComp)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_UserCompSave", userComp);
		}
		public async Task<int> DeleteUserComp(string Comp_Code,string UserId)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_UserCompDel", new { Comp_Code , UserId });
		}
	}
}
