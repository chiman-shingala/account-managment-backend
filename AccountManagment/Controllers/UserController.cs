using Acc.Services.Common;
using Acc.Services.Dtos;
using Acc.Shared.Dtos;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using Services.Services;
using System.ComponentModel.Design;
using System.Net;

namespace AccountManagment.Controllers
{
	[Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class UserController : ControllerBase
	{
		private readonly IUserService _userService;
		private readonly IConfiguration _configuration;

		public UserController(IUserService userService,IConfiguration configuration)
		{
			_userService = userService;
			_configuration = configuration;
		}		
		[HttpPost("add-user")]
		public async Task<IActionResult> AddUser([FromBody] PassMastDto addUser)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _userService.AddUser(addUser), CommonConstants.SUCCESS));
		}
		[AllowAnonymous]
		[HttpPost("login")]
		public async Task<IActionResult> Login([FromBody] LoginRequestDto request)
		{
			var result = await _userService.AuthenticateUser(request);

			if (result == 1)
			{
				var token = JwtTokenHelper.GenerateToken(request.UserId,_configuration);
				return Ok(new ApiResponse(true, HttpStatusCode.OK, token, "Login successful"));
			}
			else if (result == 2)
			{
				return Unauthorized(new ApiResponse(false, HttpStatusCode.Unauthorized, null, "Incorrect password"));
			}
			else if (result == -1)
			{
				return Unauthorized(new ApiResponse(false, HttpStatusCode.Conflict, null, "User Already Exists."));
			}
			else
			{
				return NotFound(new ApiResponse(false, HttpStatusCode.NotFound, null, "User not found"));
			}
		}
		[HttpPost("change-password")]
		public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordDto changePasswordDto)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _userService.ChangePassword(changePasswordDto), CommonConstants.SUCCESS));
		}
		[HttpDelete("delete-user")]
		public async Task<IActionResult> DeleteUser([FromQuery] string userId)
		{
			return new JsonResult(new ApiResponse(true,HttpStatusCode.OK,await _userService.DeleteUser(userId), CommonConstants.SUCCESS));
		}
	}
}
