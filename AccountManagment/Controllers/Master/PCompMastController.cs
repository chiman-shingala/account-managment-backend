using Acc.Services.Common;
using Acc.Services.Interfaces.Master;
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
	public class PCompMastController : ControllerBase
	{
		private readonly IPCompMastService _pCompMast;

		public PCompMastController(IPCompMastService pCompMast)
		{
			_pCompMast = pCompMast;
		}
		//[HttpGet("get-party")]
		//public async Task<IActionResult> GetAllParMast([FromQuery] ParMastFillDto parMastFill)
		//{
		//	return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _parMast.GetAllParMast(parMastFill), CommonConstants.SUCCESS));
		//}
		[HttpPost("add-pComp")]
		public async Task<IActionResult> AddPCompMast([FromBody] PCompMastDto pCompMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _pCompMast.AddPCompMast(pCompMast), CommonConstants.SUCCESS));
		}
		[HttpPost("update-pComp")]
		public async Task<IActionResult> UpdatePCompMast([FromBody] PCompMastDto pCompMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _pCompMast.UpdatePCompMast(pCompMast), CommonConstants.SUCCESS));
		}
		[HttpDelete("delete-party")]
		public async Task<IActionResult> DeleteParMast([FromQuery] string P_Code, int Acyear, string Comp_Code)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _pCompMast.DeletePCompMast(P_Code, Acyear, Comp_Code), CommonConstants.SUCCESS));
		}
	}
}
