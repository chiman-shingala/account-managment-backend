using Acc.Data.Interfaces.IUtility;
using Acc.Services.Interfaces.Utility;
using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Services.Utility
{
	public class UserCompService : IUserCompService
	{
		private readonly IUserCompRepository _userComp;

		public UserCompService(IUserCompRepository userComp)
		{
			_userComp = userComp;
		}
		public async Task<List<CompMastDto>> GetAllComp()
		{
			return await _userComp.GetAllComp();
		}
		public async Task<List<CompMastDto>> GetUserWiseComp(string UserId)
		{
			return await _userComp.GetUserWiseComp(UserId);
		}
		public async Task<int> AddUserComp(UserCompDto userComp)
		{
			return await _userComp.AddUserComp(userComp);
		}
		public async Task<int> UpdateUserComp(UserCompDto userComp)
		{
			return await _userComp.UpdateUserComp(userComp);
		}
		public async Task<int> DeleteUserComp(string Comp_Code, string UserId)
		{
			return await _userComp.DeleteUserComp(Comp_Code, UserId);
		}
	}
}
