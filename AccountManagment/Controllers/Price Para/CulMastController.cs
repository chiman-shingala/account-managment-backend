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
	public class CulMastController : ControllerBase
	{
		private readonly ICulMastService _culMast;

		public CulMastController(ICulMastService culMast)
		{
			_culMast = culMast;
		}
		[HttpGet("get-cul")]
		public async Task<IActionResult> GetAlCulMast()
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _culMast.GetAllCulMast(), CommonConstants.SUCCESS));
		}
		[HttpPost("add-cul")]
		public async Task<IActionResult> AddCulMast([FromBody] CulMastDto culMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _culMast.AddCulMast(culMast), CommonConstants.SUCCESS));
		}
		[HttpPost("update-cul")]
		public async Task<IActionResult> UpdateCulMast([FromBody] CulMastDto culMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _culMast.UpdateCulMast(culMast), CommonConstants.SUCCESS));
		}
		[HttpDelete("delete-cul")]
		public async Task<IActionResult> DeleteCulMast([FromQuery] short CU_Code)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _culMast.DeleteCulMast(CU_Code), CommonConstants.SUCCESS));
		}
	}
}
