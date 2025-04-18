using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Interfaces.Utility
{
	public interface IUserCompService
	{
		Task<List<CompMastDto>> GetAllComp();
		Task<List<CompMastDto>> GetUserWiseComp(string UserId);
		Task<int> AddUserComp(UserCompDto userComp);
		Task<int> UpdateUserComp(UserCompDto userComp);
		Task<int> DeleteUserComp(string Comp_Code, string UserId);
	}
}
