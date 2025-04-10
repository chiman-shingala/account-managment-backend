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
	public class CutDiscController : ControllerBase
	{
		private readonly ICutDiscService _cutDiscService;

		public CutDiscController(ICutDiscService cutDiscService)
		{
			_cutDiscService = cutDiscService;
		}
		[HttpGet("get-cutdisc")]
		public async Task<IActionResult> GetCutDisc(int SZ_Code, string S_Code,int CT_Code)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _cutDiscService.GetAllCutDisc(SZ_Code,S_Code,CT_Code), CommonConstants.SUCCESS));
		}

		[HttpPost("add-cutdisc")]
		public async Task<IActionResult> AddCutDisc([FromBody] InsertCutDiscDto cutdiscDto)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _cutDiscService.AddCutDisc(cutdiscDto), CommonConstants.SUCCESS));
		}
		[HttpPost("update-cutdisc")]
		public async Task<IActionResult> UpdateCutDisc([FromBody] InsertCutDiscDto cutdiscDto)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _cutDiscService.UpdateCutDisc(cutdiscDto), CommonConstants.SUCCESS));
		}
		[HttpDelete("delete-cutdisc")]
		public async Task<IActionResult> DeleteCutDisc(short C_Code, short SZ_Code, string S_Code,int CT_Code)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _cutDiscService.DeleteCutDisc(C_Code, SZ_Code, S_Code,CT_Code), CommonConstants.SUCCESS));
		}
	}
}
