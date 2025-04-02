using Acc.Services.Common;
using Acc.Services.Interfaces;
using Acc.Services.Services;
using Acc.Shared.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Acc.Api.Controllers.Master
{
	[Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class ColMastController : ControllerBase
	{
		private readonly IColMastService _mastService;

		public ColMastController(IColMastService mastService )
		{
			_mastService = mastService;
		}
		[HttpGet("get-colours")]
		public async Task<IActionResult> GetAllColours()
		{
			return new JsonResult(new ApiResponse(true,HttpStatusCode.OK,await _mastService.GetAllColours(),CommonConstants.SUCCESS));
		}
		[HttpPost("add-colour")]
		public async Task<IActionResult> AddColour([FromBody] ColMastDto colMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _mastService.AddColour(colMast), CommonConstants.SUCCESS));
		}
		[HttpPost("update-colour")]
		public async Task<IActionResult> UpdateColour([FromBody] ColMastDto colMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _mastService.UpdateColour(colMast), CommonConstants.SUCCESS));
		}
		[HttpDelete("delete-colour")]
		public async Task<IActionResult> DeleteColour([FromQuery ]short C_Code)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _mastService.DeleteColour(C_Code), CommonConstants.SUCCESS));
		}
	}
}
