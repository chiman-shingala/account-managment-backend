using Acc.Services.Common;
using Acc.Services.Interfaces;
using Acc.Shared.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Acc.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ParMastController : ControllerBase
	{
		private readonly IParMastService _parMast;

		public ParMastController(IParMastService parMast)
		{
			_parMast = parMast;
		}
		[HttpGet("get-party")]
		public async Task<IActionResult> GetAllParMast([FromQuery] ParMastFillDto parMastFill)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _parMast.GetAllParMast(parMastFill), CommonConstants.SUCCESS));
		}
		[HttpPost("add-party")]
		public async Task<IActionResult> AddParMast([FromBody] ParMastDto parMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _parMast.AddParMasr(parMast), CommonConstants.SUCCESS));
		}
		[HttpPost("update-party")]
		public async Task<IActionResult> UpdateParMast([FromBody] ParMastDto parMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _parMast.UpdateParMast(parMast), CommonConstants.SUCCESS));
		}
		[HttpDelete("delete-party")]
		public async Task<IActionResult> DeleteParMast([FromQuery] string P_Code, int Acyear, string Comp_Code)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _parMast.DeleteGrp(P_Code,Acyear,Comp_Code), CommonConstants.SUCCESS));
		}
	}
}
