using Acc.Services.Dtos;
using Acc.Shared.Dtos;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IUserRepository
    {
		Task<int> AuthenticateUser(LoginRequestDto requestDto);
		Task<int> AddUser(PassMastDto addUser);
		Task<int> ChangePassword(ChangePasswordDto changePasswordDto);
		Task<int> DeleteUser(string userId);
	}
}
