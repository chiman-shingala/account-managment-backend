using Acc.Services.Common;
using Acc.Services.Interfaces;
using Acc.Shared.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Acc.Api.Controllers
{
	[Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class PurityMastController : ControllerBase
	{
		private readonly IPurityService _purityService;

		public PurityMastController(IPurityService purityService)
		{
			_purityService = purityService;
		}
		[HttpGet("get-purity")]
		public async Task<IActionResult> GetAllPurity()
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _purityService.GetAllPurity(), CommonConstants.SUCCESS));
		}
		[HttpPost("add-purity")]
		public async Task<IActionResult> AddCut([FromBody] QuaMastDto quaMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _purityService.AddPurity(quaMast), CommonConstants.SUCCESS));
		}
		[HttpPost("update-purity")]
		public async Task<IActionResult> UpdateCut([FromBody] QuaMastDto quaMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _purityService.UpdatePurity(quaMast), CommonConstants.SUCCESS));
		}
		[HttpDelete("delete-purity")]
		public async Task<IActionResult> DeleteCut([FromQuery] short Q_Code)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _purityService.DeletePurity(Q_Code), CommonConstants.SUCCESS));
		}
	}
}
