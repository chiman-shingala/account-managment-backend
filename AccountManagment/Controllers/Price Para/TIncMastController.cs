using Acc.Services.Common;
using Acc.Services.Interfaces.Price_Para;
using Acc.Shared.Dtos;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Acc.Api.Controllers.Price_Para
{
	[Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class TIncMastController : ControllerBase
	{
		private readonly ITIncMastService _tIncMast;

		public TIncMastController(ITIncMastService tIncMast)
		{
			_tIncMast = tIncMast;
		}
		[HttpGet("get-tInc")]
		public async Task<IActionResult> GetAllTIncMastMast()
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _tIncMast.GetAllTIncMast(), CommonConstants.SUCCESS));
		}
		[HttpPost("add-tInc")]
		public async Task<IActionResult> AddTIncMastMast([FromBody] TIncMastDto incMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _tIncMast.AddTIncMast(incMast), CommonConstants.SUCCESS));
		}
		[HttpPost("update-tInc")]
		public async Task<IActionResult> UpdateTIncMastMast([FromBody] TIncMastDto incMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _tIncMast.UpdateTIncMast(incMast), CommonConstants.SUCCESS));
		}
		[HttpDelete("delete-tInc")]
		public async Task<IActionResult> DeleteTIncMastMast([FromQuery] short TIN_Code)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _tIncMast.DeleteTIncMast(TIN_Code), CommonConstants.SUCCESS));
		}
	}
}
