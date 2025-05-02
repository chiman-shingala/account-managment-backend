using Acc.Services.Common;
using Acc.Services.Interfaces.Price_Para;
using Acc.Shared.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Acc.Api.Controllers.Price_Para
{
	[Route("api/[controller]")]
	[ApiController]
	[Authorize]
	public class HAMastController : ControllerBase
	{
		private readonly IHAMastService _hAMast;

		public HAMastController(IHAMastService hAMast)
		{
			_hAMast = hAMast;
		}
		[HttpGet("get-AllHAMast")]
		public async Task<IActionResult> GetAllHAMast()
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _hAMast.GetAllHAMast(), CommonConstants.SUCCESS));
		}
		[HttpPost("add-HAMast")]
		public async Task<IActionResult> AddHAMast([FromBody] HAMastDto hAMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _hAMast.AddHAMast(hAMast), CommonConstants.SUCCESS));
		}
		[HttpPost("update-HAMast")]
		public async Task<IActionResult> UpdateHAMast([FromBody] HAMastDto hAMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _hAMast.UpdateHAMast(hAMast), CommonConstants.SUCCESS));
		}
		[HttpDelete("delete-HAMast")]
		public async Task<IActionResult> DeleteHAMast([FromQuery] short HA_Code)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _hAMast.DeleteHAMast(HA_Code), CommonConstants.SUCCESS));
		}
	}
}
