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
	public class GrpMastController : ControllerBase
	{
		private readonly IGrpMastService _grpMast;

		public GrpMastController(IGrpMastService grpMast)
		{
			_grpMast = grpMast;
		}
		[HttpGet("get-group")]
		public async Task<IActionResult> GetAllGroup()
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _grpMast.GetAllGrp(), CommonConstants.SUCCESS));
		}
		[HttpPost("add-group")]
		public async Task<IActionResult> AddGroup([FromBody] GrpMastDto grpMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _grpMast.AddGrp(grpMast), CommonConstants.SUCCESS));
		}
		[HttpPost("update-group")]
		public async Task<IActionResult> UpdateGroup([FromBody] GrpMastDto grpMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _grpMast.UpdateGrp(grpMast), CommonConstants.SUCCESS));
		}
		[HttpDelete("delete-group")]
		public async Task<IActionResult> DeleteGroup([FromQuery] string Gr_Code)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _grpMast.DeleteGrp(Gr_Code), CommonConstants.SUCCESS));
		}
	}
}
