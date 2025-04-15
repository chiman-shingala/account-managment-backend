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
	public class TBIncMastController : ControllerBase
	{
		private readonly ITBIncMastService _tBIncMast;

		public TBIncMastController(ITBIncMastService tBIncMast)
		{
			_tBIncMast = tBIncMast;
		}
		[HttpGet("get-tBInc")]
		public async Task<IActionResult> GetAllTBIncMastMast()
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _tBIncMast.GetAllTBIncMast(), CommonConstants.SUCCESS));
		}
		[HttpPost("add-tBInc")]
		public async Task<IActionResult> AddTOIncMastMast([FromBody] TBIncMastDto tBIncMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _tBIncMast.AddTBIncMast(tBIncMast), CommonConstants.SUCCESS));
		}
		[HttpPost("update-tBInc")]
		public async Task<IActionResult> UpdateTOIncMastMast([FromBody] TBIncMastDto tBIncMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _tBIncMast.UpdateTBIncMast(tBIncMast), CommonConstants.SUCCESS));
		}
		[HttpDelete("delete-tBInc")]
		public async Task<IActionResult> DeleteTOIncMastMast([FromQuery] short TbinCode)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _tBIncMast.DeleteTBIncMast(TbinCode), CommonConstants.SUCCESS));
		}
	}
}
