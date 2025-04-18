using Acc.Data.Interfaces.IMaster;
using Acc.Services.Common;
using Acc.Services.Dtos;
using Acc.Shared.Dtos;
using Azure.Core;
using Data.Models;
using Services.Interfaces;
using System.Threading.Tasks;

namespace Acc.Services.Services.Master
{
    public class UserService : IUserService
	{
		private readonly IUserRepository _userRepository;

		public UserService(IUserRepository userRepository)
		{
			_userRepository = userRepository;
		}		
		public async Task<int> AddUser(PassMastDto userDto)
		{
			userDto.Password = EncryptionDescryption.Encode_Decode(userDto.Password, "E");
			return await _userRepository.AddUser(userDto);
		}
		public async Task<int> AuthenticateUser(LoginRequestDto requestDto)
		{
			return await _userRepository.AuthenticateUser(requestDto);
		}
		public async Task<string> ChangePassword(ChangePasswordDto changePasswordDto)
		{
			var user = await _userRepository.IsUserExist(changePasswordDto.UserId);
			if(user == null)
			{
				return "Invalid User";
			}
			string decodedOldPass = EncryptionDescryption.Encode_Decode(changePasswordDto.OldPassword, "E");
			if (!user.Password.Equals(decodedOldPass, StringComparison.OrdinalIgnoreCase))
			{
				return "Invalid Old Password. Please Enter Correct Password.";
			}
			
			changePasswordDto.NewPassword = EncryptionDescryption.Encode_Decode(changePasswordDto.NewPassword, "E");

			await _userRepository.ChangePassword(changePasswordDto);
		
			return "Password Changed Successfully"; 
		}
		public async Task<int> DeleteUser(string userId)
		{
			return await _userRepository.DeleteUser(userId);	
		}
	}
}
