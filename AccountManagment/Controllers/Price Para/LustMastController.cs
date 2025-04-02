using Acc.Services.Common;
using Acc.Services.Interfaces;
using Acc.Shared.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Acc.Api.Controllers.Price_Para
{
	[Route("api/[controller]")]
	[ApiController]
	public class LustMastController : ControllerBase
	{
		private readonly ILustMastService _lustMast;

		public LustMastController(ILustMastService lustMast)
		{
			_lustMast = lustMast;
		}
		[HttpGet("get-lust")]
		public async Task<IActionResult> GetAllLustMast()
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _lustMast.GetAllLustMast(), CommonConstants.SUCCESS));
		}
		[HttpPost("add-lust")]
		public async Task<IActionResult> AddLustMast([FromBody] LustMastDto lustMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _lustMast.AddLustMast(lustMast), CommonConstants.SUCCESS));
		}
		[HttpPost("update-lust")]
		public async Task<IActionResult> UpdateLustMast([FromBody] LustMastDto lustMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _lustMast.UpdateLustMast(lustMast), CommonConstants.SUCCESS));
		}
		[HttpDelete("delete-lust")]
		public async Task<IActionResult> DeleteLustMast([FromQuery] short LU_Code)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _lustMast.DeleteLustMast(LU_Code), CommonConstants.SUCCESS));
		}
	}
}
