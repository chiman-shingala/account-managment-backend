using Acc.Data.Interfaces.IMaster;
using Acc.Data.Repositories;
using Acc.Data.Repository.Interface;
using Acc.Services.Common;
using Acc.Services.Dtos;
using Acc.Shared.Dtos;
using Data.Models;
using Microsoft.EntityFrameworkCore;


namespace Acc.Data.Repositories.Master
{
	public class UserRepository : IUserRepository
	{
		private readonly DratnaContext _context;
		private readonly IDRepository _dRepository;

		public UserRepository(DratnaContext context, IDRepository dRepository)
		{
			_context = context;
			_dRepository = dRepository;
		}
		
		public async Task<int> AddUser(PassMastDto addUser)
		{
			var  userExists = await IsUserExist(addUser.UserId);
			if(userExists == null)
			{
				return await _dRepository.ExecuteAsyncQuery("SP_UtilUserMastCreateUser", addUser);
			}
			return -1;
		}
		public async Task<int> AuthenticateUser(LoginRequestDto requestDto)
		{
			 var result = await _dRepository.GetAll<PassMast>("SP_UserLoginAuthentication", new { requestDto.UserId });
			if (result == null || result.Count == 0) 
			{
				return 0;
			}
			var userRecord = result.FirstOrDefault();
			if (userRecord == null) 
			{
				return 0;
			}
			if(userRecord.Password == null)
			{
				return 0;
			}
			string decryptedPassword = EncryptionDescryption.Encode_Decode(userRecord.Password, "D");

			if (decryptedPassword == requestDto.Password)
			{
				return 1;
			}
			else
			{
				return 2;
			}
		}			
		public async Task<PassMastDto> IsUserExist(string userId)
		{
			var parameters = new { UserId = userId };
			var result = await _dRepository.QuerySingleOrDefaultAsync<PassMastDto>("SP_UtilCheckUserLogin", parameters);

			return result;
		}
		public async Task<int> ChangePassword(ChangePasswordDto changePasswordDto)
		{
			var parameter = new
			{
				UserId = changePasswordDto.UserId,
				Password = changePasswordDto.NewPassword
			};
			return await _dRepository.ExecuteAsyncQuery("SP_UtilUserMastChangePass", parameter);
		}
		public async Task<int> DeleteUser(string userId)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_UtilUserMastUserDel",new {userId});
		}
	}
}
