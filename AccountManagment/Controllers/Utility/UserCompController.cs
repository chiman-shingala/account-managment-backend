using Acc.Services.Common;
using Acc.Services.Interfaces.Utility;
using Acc.Shared.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Acc.Api.Controllers.Utility
{
	[Route("api/[controller]")]
	[ApiController]
	public class UserCompController : ControllerBase
	{
		private readonly IUserCompService _userComp;

		public UserCompController(IUserCompService userComp)
		{
			_userComp = userComp;
		}
		[HttpGet("get-userWiseComp")]
		public async Task<IActionResult> GetUserWiseComp(string UserId)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _userComp.GetUserWiseComp(UserId), CommonConstants.SUCCESS));
		}
		[HttpGet("get-allComp")]
		public async Task<IActionResult> GetAllComp()
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _userComp.GetAllComp(), CommonConstants.SUCCESS));
		}
		[HttpPost("add-userComp")]
		public async Task<IActionResult> AddUserComp([FromBody] UserCompDto userComp)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _userComp.AddUserComp(userComp), CommonConstants.SUCCESS));
		}
		[HttpPost("update-userComp")]
		public async Task<IActionResult> UpdateUserComp([FromBody] UserCompDto userComp)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _userComp.UpdateUserComp(userComp), CommonConstants.SUCCESS));
		}
		[HttpDelete("delete-userComp")]
		public async Task<IActionResult> DeleteUserComp(string Comp_Code, string UserId)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _userComp.DeleteUserComp(Comp_Code, UserId), CommonConstants.SUCCESS));
		}
	}
}
