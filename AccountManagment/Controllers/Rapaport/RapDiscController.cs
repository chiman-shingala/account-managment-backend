using Acc.Services.Common;
using Acc.Services.Interfaces.Rapaport;
using Acc.Shared.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Acc.Api.Controllers.Rapaport
{
	[Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class RapDiscController : ControllerBase
	{
		private readonly IRapDiscService _rapDiscService;

		public RapDiscController(IRapDiscService rapDiscService)
		{
			_rapDiscService = rapDiscService;
		}
		[HttpGet("get-rapdisc")]
		public async Task<IActionResult> GetRapDisc(int SZ_Code = 0, string S_Code = null)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _rapDiscService.GetAllRapDisc(SZ_Code,S_Code), CommonConstants.SUCCESS));
		}

		[HttpPost("add-rapdisc")]
		public async Task<IActionResult> AddRapDisc([FromBody] InsertRapDiscDto rapDiscDto)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _rapDiscService.AddRapDisc(rapDiscDto), CommonConstants.SUCCESS));
		}
		[HttpPost("update-rapdisc")]
		public async Task<IActionResult> UpdateRapDisc([FromBody] InsertRapDiscDto rapDiscDto)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _rapDiscService.UpdateRapDisc(rapDiscDto), CommonConstants.SUCCESS));
		}
		[HttpDelete("delete-rapdisc")]
		public async Task<IActionResult> DeleteRapDisc(short C_Code, short SZ_Code, string S_Code)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _rapDiscService.DeleteRapDisc(C_Code, SZ_Code, S_Code), CommonConstants.SUCCESS));
		}
	}
}
