using Acc.Services.Common;
using Acc.Services.Interfaces.Master;
using Acc.Shared.Dtos;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Acc.Api.Controllers.Master
{
	[Route("api/[controller]")]
	[ApiController]
	public class FloMastController : ControllerBase
	{
		private readonly IFloMastService _floMast;

		public FloMastController(IFloMastService floMast)
		{
			_floMast = floMast;
		}
		[HttpGet("get-FloMast")]
		public async Task<IActionResult> GetAllDesgMast()
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _floMast.GetAllFloMast(), CommonConstants.SUCCESS));
		}
		[HttpPost("add-FloMast")]
		public async Task<IActionResult> AddFloMast([FromBody] FloMastDto floMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _floMast.AddFloMast(floMast), CommonConstants.SUCCESS));
		}
		[HttpPost("update-FloMast")]
		public async Task<IActionResult> UpdateFloMast([FromBody] FloMastDto floMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _floMast.UpdateFloMast(floMast), CommonConstants.SUCCESS));
		}
		[HttpDelete("delete-FloMast")]
		public async Task<IActionResult> DeleteFloMast([FromQuery] string FL_Code)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _floMast.DeleteFloMast(FL_Code), CommonConstants.SUCCESS));
		}
	}
}
