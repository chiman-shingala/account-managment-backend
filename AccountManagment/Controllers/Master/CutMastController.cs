using Acc.Services.Common;
using Acc.Services.Interfaces;
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
	public class CutMastController : ControllerBase
	{
		private readonly ICutMastService _cutMast;

		public CutMastController(ICutMastService cutMast)
		{
			_cutMast = cutMast;
		}
		[HttpGet("get-cuts")]
		public async Task<IActionResult> GetAllCuts()
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _cutMast.GetAllCuts(), CommonConstants.SUCCESS));
		}
		[HttpPost("add-cut")]
		public async Task<IActionResult> AddCut([FromBody] CutMastDto cutMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _cutMast.AddCut(cutMast), CommonConstants.SUCCESS));
		}
		[HttpPost("update-cut")]
		public async Task<IActionResult> UpdateCut([FromBody] CutMastDto cutMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _cutMast.UpdateCut(cutMast), CommonConstants.SUCCESS));
		}
		[HttpDelete("delete-cut")]
		public async Task<IActionResult> DeleteCut([FromQuery] short CT_Code)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _cutMast.DeleteCut(CT_Code), CommonConstants.SUCCESS));
		}
	}
}
