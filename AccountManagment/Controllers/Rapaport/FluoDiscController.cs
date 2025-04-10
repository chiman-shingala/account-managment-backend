using Acc.Services.Common;
using Acc.Services.Interfaces.Rapaport;
using Acc.Services.Services.Rapaport;
using Acc.Shared.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Acc.Api.Controllers.Rapaport
{
	[Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class FluoDiscController : ControllerBase
	{
		private readonly IFluoDiscService _fluoDiscService;

		public FluoDiscController(IFluoDiscService fluoDiscService)
		{
			_fluoDiscService = fluoDiscService;
		}
		[HttpGet("get-fluodisc")]
		public async Task<IActionResult> GetFluoDisc(int SZ_Code, string S_Code, int FL_Code)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _fluoDiscService.GetAllFluoDisc(SZ_Code,S_Code,FL_Code), CommonConstants.SUCCESS));
		}

		[HttpPost("add-fluodisc")]
		public async Task<IActionResult> AddFluoDisc([FromBody] InsertFluoDiscDto fluoDiscDto)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _fluoDiscService.AddFluoDisc(fluoDiscDto), CommonConstants.SUCCESS));
		}
		[HttpPost("update-fluodisc")]
		public async Task<IActionResult> UpdateFluoDisc([FromBody] InsertFluoDiscDto fluoDiscDto)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _fluoDiscService.UpdateCutDisc(fluoDiscDto), CommonConstants.SUCCESS));
		}
		[HttpDelete("delete-fluodisc")]
		public async Task<IActionResult> DeleteFluoDisc(short C_Code, short SZ_Code, string S_Code, int FL_Code)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _fluoDiscService.DeleteCutDisc(C_Code,SZ_Code,S_Code,FL_Code), CommonConstants.SUCCESS));
		}
	}
}
