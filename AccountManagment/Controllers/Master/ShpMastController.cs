using Acc.Services.Common;
using Acc.Services.Interfaces.Master;
using Acc.Services.Services;
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
	public class ShpMastController : ControllerBase
	{
		private readonly IShpMastService _shpMast;

		public ShpMastController(IShpMastService shpMast)
		{
			_shpMast = shpMast;
		}
		[HttpGet("get-shape")]
		public async Task<IActionResult> GetAllShape()
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _shpMast.GetAllShape(), CommonConstants.SUCCESS));
		}
		[HttpPost("add-shape")]
		public async Task<IActionResult> AddShape([FromBody] ShpMastDto shpMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _shpMast.AddShape(shpMast), CommonConstants.SUCCESS));
		}
		[HttpPost("update-shape")]
		public async Task<IActionResult> UpdateShape([FromBody] ShpMastDto shpMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _shpMast.UpdateShape(shpMast), CommonConstants.SUCCESS));
		}
		[HttpDelete("delete-shape")]
		public async Task<IActionResult> DeleteCut([FromQuery] string S_Code)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _shpMast.DeleteShape(S_Code), CommonConstants.SUCCESS));
		}
	}
}
