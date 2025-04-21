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
	[Route("api/[controller]")]
	[ApiController]
	[Authorize]
	public class GirdMastController : ControllerBase
	{
		private readonly IGirdMastService _girdMast;

		public GirdMastController(IGirdMastService girdMast)
		{
			_girdMast = girdMast;
		}
		[HttpGet("get-AllGridMast")]
		public async Task<IActionResult> GetAllGridMast()
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _girdMast.GetAllGridMast(), CommonConstants.SUCCESS));			
		}
		[HttpPost("add-GridMast")]
		public async Task<IActionResult> AddGridMast([FromBody] GirdMastDto girdMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _girdMast.AddGridMast(girdMast), CommonConstants.SUCCESS));
		}
		[HttpPost("update-GridMast")]
		public async Task<IActionResult> UpdateGridMast([FromBody] GirdMastDto girdMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _girdMast.UpdateGridMast(girdMast), CommonConstants.SUCCESS));
		}
		[HttpDelete("delete-GridMast")]
		public async Task<IActionResult> DeleteGridMast([FromQuery] string Gr_Code)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _girdMast.DeleteGridMast(Gr_Code), CommonConstants.SUCCESS));
		}
	}
}
