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
	public class RemaindMastController : ControllerBase
	{
		private readonly IRemaindMastService _remaindMast;

		public RemaindMastController(IRemaindMastService remaindMast)
		{
			_remaindMast = remaindMast;
		}
		[HttpGet("get-Remaind")]
		public async Task<IActionResult> GetAllRemaindMast()
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _remaindMast.GetAllRemaindMast(), CommonConstants.SUCCESS));
		}
		[HttpPost("add-Remaind")]
		public async Task<IActionResult> AddRemaindMast([FromBody] RemaindMastDto remaindMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _remaindMast.AddRemaindMast(remaindMast), CommonConstants.SUCCESS));
		}
		[HttpPost("update-Remaind")]
		public async Task<IActionResult> UpdateRemaindMast([FromBody] RemaindMastDto remaindMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _remaindMast.UpdateRemaindMast(remaindMast), CommonConstants.SUCCESS));
		}
		[HttpDelete("delete-Remaind")]
		public async Task<IActionResult> DeleteCut([FromQuery] string Rem_Code)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _remaindMast.DeleteRemaindMast(Rem_Code), CommonConstants.SUCCESS));
		}
	}
}
