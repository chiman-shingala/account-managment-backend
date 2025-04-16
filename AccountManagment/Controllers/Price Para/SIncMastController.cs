using Acc.Services.Common;
using Acc.Services.Interfaces.Price_Para;
using Acc.Shared.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Acc.Api.Controllers.Price_Para
{
	[Route("api/[controller]")]
	[ApiController]
	public class SIncMastController : ControllerBase
	{
		private readonly ISIncMastService _sIncMast;

		public SIncMastController(ISIncMastService sIncMast)
		{
			_sIncMast = sIncMast;
		}
		[HttpGet("get-sInc")]
		public async Task<IActionResult> GetAllSIncMastMast()
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _sIncMast.GetAllSIncMast(), CommonConstants.SUCCESS));
		}
		[HttpPost("add-sInc")]
		public async Task<IActionResult> AddSIncMastMast([FromBody] SIncMastDto sIncMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _sIncMast.AddSIncMast(sIncMast), CommonConstants.SUCCESS));
		}
		[HttpPost("update-sInc")]
		public async Task<IActionResult> UpdateSIncMastMast([FromBody] SIncMastDto sIncMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _sIncMast.UpdateSIncMast(sIncMast), CommonConstants.SUCCESS));
		}
		[HttpDelete("delete-sInc")]
		public async Task<IActionResult> DeleteSIncMastMast([FromQuery] short SIN_Code)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _sIncMast.DeleteSIncMast(SIN_Code), CommonConstants.SUCCESS));
		}
	}
}
