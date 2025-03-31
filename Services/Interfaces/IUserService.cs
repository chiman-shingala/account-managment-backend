using Acc.Services.Dtos;
using Acc.Shared.Dtos;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IUserService
    {
		Task<int> AuthenticateUser(LoginRequestDto requestDto);
		Task<int> AddUser(PassMastDto userDto);
		Task<int> ChangePassword(ChangePasswordDto changePasswordDto);
		Task<int> DeleteUser(string userId);
	}

}
