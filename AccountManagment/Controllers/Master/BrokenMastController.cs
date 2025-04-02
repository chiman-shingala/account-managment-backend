using Acc.Services.Common;
using Acc.Services.Interfaces;
using Acc.Shared.Dtos;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Acc.Api.Controllers.Master
{
	[Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class BrokenMastController : ControllerBase
	{
		private readonly IBrokenMastService _brokenMast;

		public BrokenMastController(IBrokenMastService brokenMast)
		{
			_brokenMast = brokenMast;
		}
		[HttpGet("get-broken")]
		public async Task<IActionResult> GetAllBroken()
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _brokenMast.GetAllBrokenMast(), CommonConstants.SUCCESS));
		}
		[HttpPost("add-broken")]
		public async Task<IActionResult> AddBrokenMast([FromBody] BrokenMastDto brokenMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _brokenMast.AddBroken(brokenMast), CommonConstants.SUCCESS));
		}
		[HttpPost("update-broken")]
		public async Task<IActionResult> UpdateBrokenMast([FromBody] BrokenMastDto brokenMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _brokenMast.UpdateBroken(brokenMast), CommonConstants.SUCCESS));
		}
		[HttpDelete("delete-broken")]
		public async Task<IActionResult> DeleteBroken([FromQuery] string BRO_Code)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _brokenMast.DeleteBroken(BRO_Code), CommonConstants.SUCCESS));
		}
	}
}
