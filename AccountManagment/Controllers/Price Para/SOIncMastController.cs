using Acc.Services.Common;
using Acc.Services.Interfaces.Price_Para;
using Acc.Shared.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Acc.Api.Controllers.Price_Para
{
	[Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class SOIncMastController : ControllerBase
	{
		private readonly ISOIncMastService _sOIncMast;

		public SOIncMastController(ISOIncMastService sOIncMast)
		{
			_sOIncMast = sOIncMast;
		}
		[HttpGet("get-sOInc")]
		public async Task<IActionResult> GetAllSOIncMastMast()
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _sOIncMast.GetAllSOIncMast(), CommonConstants.SUCCESS));
		}
		[HttpPost("add-sOInc")]
		public async Task<IActionResult> AddSOIncMastMast([FromBody] SoincMastDto soincMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _sOIncMast.AddSOIncMast(soincMast), CommonConstants.SUCCESS));
		}
		[HttpPost("update-sOInc")]
		public async Task<IActionResult> UpdateSOIncMastMast([FromBody] SoincMastDto soincMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _sOIncMast.UpdateSOIncMast(soincMast), CommonConstants.SUCCESS));
		}
		[HttpDelete("delete-sOInc")]
		public async Task<IActionResult> DeleteSOIncMastMast([FromQuery] short SOIN_Code)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _sOIncMast.DeleteSOIncMast(SOIN_Code), CommonConstants.SUCCESS));
		}
	}
}
