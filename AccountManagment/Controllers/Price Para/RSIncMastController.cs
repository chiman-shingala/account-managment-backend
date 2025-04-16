using Acc.Services.Common;
using Acc.Services.Interfaces.Price_Para;
using Acc.Shared.Dtos;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Acc.Api.Controllers.Price_Para
{
	[Route("api/[controller]")]
	[ApiController]
	public class RSIncMastController : ControllerBase
	{
		private readonly IRSIncMastService _rSIncMast;

		public RSIncMastController(IRSIncMastService rSIncMast)
		{
			_rSIncMast = rSIncMast;
		}
		[HttpGet("get-rSInc")]
		public async Task<IActionResult> GetAllRSIncMastMast()
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _rSIncMast.GetAllRSIncMast(), CommonConstants.SUCCESS));
		}
		[HttpPost("add-rSInc")]
		public async Task<IActionResult> AddRSIncMastMast([FromBody] RsincMastDto rsincMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _rSIncMast.AddRSIncMast(rsincMast), CommonConstants.SUCCESS));
		}
		[HttpPost("update-rSInc")]
		public async Task<IActionResult> UpdateRSIncMastMast([FromBody] RsincMastDto rsincMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _rSIncMast.UpdateRSIncMast(rsincMast), CommonConstants.SUCCESS));
		}
		[HttpDelete("delete-rSInc")]
		public async Task<IActionResult> DeleteRSIncMastMast([FromQuery] short RSIN_Code)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _rSIncMast.DeleteRSIncMast(RSIN_Code), CommonConstants.SUCCESS));
		}
	}
}
