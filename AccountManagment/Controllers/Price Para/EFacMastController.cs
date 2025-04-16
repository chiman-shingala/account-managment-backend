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
	public class EFacMastController : ControllerBase
	{
		private readonly IEFacMastService _eFacMast;

		public EFacMastController(IEFacMastService eFacMast)
		{
			_eFacMast = eFacMast;
		}
		[HttpGet("get-eFac")]
		public async Task<IActionResult> GetAllEFacMast()
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _eFacMast.GetAllEFacMast(), CommonConstants.SUCCESS));
		}
		[HttpPost("add-eFac")]
		public async Task<IActionResult> AddEFacMast([FromBody] EfacMastDto efacMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _eFacMast.AddlEFacMast(efacMast), CommonConstants.SUCCESS));
		}
		[HttpPost("update-eFac")]
		public async Task<IActionResult> UpdateEFacMast([FromBody] EfacMastDto efacMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _eFacMast.UpdatelEFacMast(efacMast), CommonConstants.SUCCESS));
		}
		[HttpDelete("delete-eFac")]
		public async Task<IActionResult> DeleteEFacMast([FromQuery] short EF_Code)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _eFacMast.DeletelEFacMast(EF_Code), CommonConstants.SUCCESS));
		}
	}
}
