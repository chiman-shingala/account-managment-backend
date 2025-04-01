using Acc.Services.Common;
using Acc.Services.Interfaces;
using Acc.Shared.Dtos;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Acc.Api.Controllers
{
	[Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class DesgMastController : ControllerBase
	{
		private readonly IDesgMastService _desgMast;

		public DesgMastController(IDesgMastService desgMast)
		{
			_desgMast = desgMast;
		}
		[HttpGet("get-design")]
		public async Task<IActionResult> GetAllDesgMast()
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _desgMast.GetAllDesgMast(), CommonConstants.SUCCESS));
		}
		[HttpPost("add-design")]
		public async Task<IActionResult> AddDesgMast([FromBody] DesgMastDto desgMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _desgMast.AddDesgMast(desgMast), CommonConstants.SUCCESS));
		}
		[HttpPost("update-design")]
		public async Task<IActionResult> UpdateDesgMast([FromBody] DesgMastDto desgMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _desgMast.UpdateDesgMast(desgMast), CommonConstants.SUCCESS));
		}
		[HttpDelete("delete-design")]
		public async Task<IActionResult> DeleteDesgMast([FromQuery] string D_Code)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _desgMast.DeleteDesgMast(D_Code), CommonConstants.SUCCESS));
		}
	}
}
