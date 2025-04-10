using Acc.Services.Common;
using Acc.Services.Interfaces.Master;
using Acc.Shared.Dtos;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Acc.Api.Controllers.Master
{
	[Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class SizeMastController : ControllerBase
	{
		private readonly ISizeMastService _sizeMast;

		public SizeMastController(ISizeMastService sizeMast)
		{
			_sizeMast = sizeMast;
		}
		[HttpGet("get-size")]
		public async Task<IActionResult> GetAllShape()
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _sizeMast.GetAllSize(), CommonConstants.SUCCESS));
		}
		[HttpPost("add-size")]
		public async Task<IActionResult> AddShape([FromBody] SizeMastDto sizeMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _sizeMast.AddSize(sizeMast), CommonConstants.SUCCESS));
		}
		[HttpPost("update-size")]
		public async Task<IActionResult> UpdateShape([FromBody] SizeMastDto sizeMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _sizeMast.UpdateSize(sizeMast), CommonConstants.SUCCESS));
		}
		[HttpDelete("delete-size")]
		public async Task<IActionResult> DeleteCut([FromQuery] short SZ_Code)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _sizeMast.DeleteSize(SZ_Code), CommonConstants.SUCCESS));
		}
	}
}
