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
	public class PerMastController : ControllerBase
	{
		private readonly IPerMastService _perMast;

		public PerMastController(IPerMastService perMast)
		{
			_perMast = perMast;
		}
		[HttpGet("get-perMast")]
		public async Task<IActionResult> GetPerMast(string User_Name)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _perMast.GetAllPerMast(User_Name), CommonConstants.SUCCESS));
		}
		[HttpGet("get-userWiseMenu")]
		public async Task<IActionResult> GetUserWiseMenu(string User_Name)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _perMast.GetUserWiseMenu(User_Name), CommonConstants.SUCCESS));
		}
		[HttpPost("add-perMast")]
		public async Task<IActionResult> AddPerMast([FromBody] PerMastDto perMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _perMast.AddPerMast(perMast), CommonConstants.SUCCESS));
		}
		[HttpPost("update-perMast")]
		public async Task<IActionResult> UpdatePerMast([FromBody] PerMastDto perMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _perMast.UpdatePerMast(perMast), CommonConstants.SUCCESS));
		}
		[HttpDelete("delete-perMast")]
		public async Task<IActionResult> DeletePerMast(string USER_NAME, string FORM_NAME)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _perMast.DeletePerMast(USER_NAME, FORM_NAME), CommonConstants.SUCCESS));
		}
	}
}
