using Acc.Services.Common;
using Acc.Services.Interfaces.Price_Para;
using Acc.Shared.Dtos;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Acc.Api.Controllers.Price_Para
{
	[Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class BrnMastController : ControllerBase
	{
		private readonly IBrnMastService _brnMast;

		public BrnMastController(IBrnMastService brnMast)
		{
			_brnMast = brnMast;
		}
		[HttpGet("get-brn")]
		public async Task<IActionResult> GetAllBrnMast()
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _brnMast.GetAllBrnMast(), CommonConstants.SUCCESS));
		}
		[HttpPost("add-brn")]
		public async Task<IActionResult> AddBrnMast([FromBody] BrnMastDto brnMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _brnMast.AddBrnMast(brnMast), CommonConstants.SUCCESS));
		}
		[HttpPost("update-brn")]
		public async Task<IActionResult> UpdateBrnMast([FromBody] BrnMastDto brnMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _brnMast.UpdateBrnMast(brnMast), CommonConstants.SUCCESS));
		}
		[HttpDelete("delete-brn")]
		public async Task<IActionResult> DeleteBrnMast([FromQuery] short BRN_Code)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _brnMast.DeleteBrnMast(BRN_Code), CommonConstants.SUCCESS));
		}
	}
}
