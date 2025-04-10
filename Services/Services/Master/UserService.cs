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
		public async Task<int> ChangePassword(ChangePasswordDto changePasswordDto)
		{
			string password = EncryptionDescryption.Encode_Decode(changePasswordDto.Password, "E");
			changePasswordDto.Password = password;
			return await _userRepository.ChangePassword(changePasswordDto);
		}
		public async Task<int> DeleteUser(string userId)
		{
			return await _userRepository.DeleteUser(userId);	
		}
	}
}
