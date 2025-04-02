using Acc.Services.Common;
using Acc.Services.Interfaces;
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
	public class CurrMastController : ControllerBase
	{
		private readonly ICurrMastService _currMast;

		public CurrMastController(ICurrMastService currMast)
		{
			_currMast = currMast;
		}
		[HttpGet("get-current")]
		public async Task<IActionResult> GetAllCurrent()
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _currMast.GetAllCurrent(), CommonConstants.SUCCESS));
		}
		[HttpPost("add-current")]
		public async Task<IActionResult> AddCurrent([FromBody] CurrMastDto currMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _currMast.AddCurrent(currMast), CommonConstants.SUCCESS));
		}
		[HttpPost("update-current")]
		public async Task<IActionResult> UpdateCurrent([FromBody] CurrMastDto currMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _currMast.UpdateCurrent(currMast), CommonConstants.SUCCESS));
		}
		[HttpDelete("delete-current")]
		public async Task<IActionResult> DeleteCurrent([FromQuery] string CnCy)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _currMast.DeleteCurrent(CnCy), CommonConstants.SUCCESS));
		}
	}
}
