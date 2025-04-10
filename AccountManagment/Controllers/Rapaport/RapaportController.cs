using Acc.Services.Common;
using Acc.Services.Interfaces.Rapaport;
using Acc.Shared.Dtos;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Acc.Api.Controllers.Rapaport
{
	[Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class RapaportController : ControllerBase
	{
		private readonly IRapaportService _rapaportService;

		public RapaportController(IRapaportService rapaportService)
		{
			_rapaportService = rapaportService;
		}
		[HttpGet("get-rapaport")]
		public async Task<IActionResult> GetRapaport(int SZ_Code , string S_Code)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _rapaportService.GetRapaport(SZ_Code, S_Code), CommonConstants.SUCCESS));
		}

		[HttpPost("add-rapaport")]
		public async Task<IActionResult> AddRapaport([FromBody] InsertRapaportDto rapaportDto)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _rapaportService.AddRapaport(rapaportDto), CommonConstants.SUCCESS));
		}
		[HttpPost("update-rapaport")]
		public async Task<IActionResult> UpdateRapaport([FromBody] InsertRapaportDto rapaportDto)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _rapaportService.UpdateRapaport(rapaportDto), CommonConstants.SUCCESS));
		}
	}
}
