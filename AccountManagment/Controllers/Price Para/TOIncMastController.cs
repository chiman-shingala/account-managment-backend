using Acc.Services.Common;
using Acc.Services.Interfaces.Price_Para;
using Acc.Shared.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Acc.Api.Controllers.Price_Para
{
	[Route("api/[controller]")]
	[ApiController]
	public class TOIncMastController : ControllerBase
	{
		private readonly ITOIncMastService _tOIncMast;

		public TOIncMastController(ITOIncMastService tOIncMast)
		{
			_tOIncMast = tOIncMast;
		}
		[HttpGet("get-tOInc")]
		public async Task<IActionResult> GetAllTOIncMastMast()
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _tOIncMast.GetAllTOIncMast(), CommonConstants.SUCCESS));
		}
		[HttpPost("add-tOInc")]
		public async Task<IActionResult> AddTOIncMastMast([FromBody] TOIncMastDto tOIncMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _tOIncMast.AddTOIncMast(tOIncMast), CommonConstants.SUCCESS));
		}
		[HttpPost("update-tOInc")]
		public async Task<IActionResult> UpdateTOIncMastMast([FromBody] TOIncMastDto tOIncMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _tOIncMast.UpdateTOIncMast(tOIncMast), CommonConstants.SUCCESS));
		}
		[HttpDelete("delete-tOInc")]
		public async Task<IActionResult> DeleteTOIncMastMast([FromQuery] short TinCode)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _tOIncMast.DeleteTIncMast(TinCode), CommonConstants.SUCCESS));
		}
	}
}
