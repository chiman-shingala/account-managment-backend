using Acc.Services.Common;
using Acc.Services.Interfaces.Master;
using Acc.Shared.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Acc.Api.Controllers.Master
{
	[Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class AccYearController : ControllerBase
	{
		private readonly IAccYearService _accYear;

		public AccYearController(IAccYearService accYear)
		{
			_accYear = accYear;
		}
		[HttpGet("get-accyear")]
		public async Task<IActionResult> GetAllAccYear(string Comp_Code)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _accYear.GetAllAccYear(Comp_Code), CommonConstants.SUCCESS));
		}
		[HttpPost("add-accyear")]
		public async Task<IActionResult> AddAccyear([FromBody] AccYearDto accYear)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _accYear.AddAccYear(accYear), CommonConstants.SUCCESS));
		}
		[HttpPost("update-accyear")]
		public async Task<IActionResult> UpdateAccyear([FromBody] AccYearDto accYear)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _accYear.UpdateAccYear(accYear), CommonConstants.SUCCESS));
		}
		[HttpDelete("delete-accyear")]
		public async Task<IActionResult> DeleteCut([FromQuery] string Comp_Code, int AcYear)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _accYear.DeleteAccYear(Comp_Code, AcYear), CommonConstants.SUCCESS));
		}
	}
}

