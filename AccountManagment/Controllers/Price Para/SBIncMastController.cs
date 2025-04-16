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
	public class SBIncMastController : ControllerBase
	{
		private readonly ISBIncMastService _sBIncMast;

		public SBIncMastController(ISBIncMastService sBIncMast)
		{
			_sBIncMast = sBIncMast;
		}
		[HttpGet("get-sBInc")]
		public async Task<IActionResult> GetAllSBIncMastMast()
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _sBIncMast.GetAllSBIncMast(), CommonConstants.SUCCESS));
		}
		[HttpPost("add-sBInc")]
		public async Task<IActionResult> AddSBIncMastMast([FromBody] SbincMastDto sbincMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _sBIncMast.AddSBIncMast(sbincMast), CommonConstants.SUCCESS));
		}
		[HttpPost("update-sBInc")]
		public async Task<IActionResult> UpdateSBIncMastMast([FromBody] SbincMastDto sbincMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _sBIncMast.UpdateSBIncMast(sbincMast), CommonConstants.SUCCESS));
		}
		[HttpDelete("delete-sBInc")]
		public async Task<IActionResult> DeleteSBIncMastMast([FromQuery] short SBIN_Code)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _sBIncMast.DeleteSIncMast(SBIN_Code), CommonConstants.SUCCESS));
		}
	}
}
