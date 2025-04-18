using Acc.Services.Common;
using Acc.Services.Interfaces.Utility;
using Acc.Shared.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Acc.Api.Controllers.Utility
{
	[Authorize]
	[Route("api/[controller]")]
	[ApiController]
	
	public class SalEncRateController : ControllerBase
	{
		private readonly ISalEncRateService _salEncRate;

		public SalEncRateController(ISalEncRateService salEncRate)
		{
			_salEncRate = salEncRate;
		}
		[HttpGet("get-allSalEncRate")]
		public async Task<IActionResult> GetAllSalEncRate(string Comp_Code)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _salEncRate.GetAllSalEncRate(Comp_Code), CommonConstants.SUCCESS));			
		}
		[HttpPost("add-salEncRate")]
		public async Task<IActionResult> AddSalEncRate([FromBody] SalEncRateDto salEncRateDto)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _salEncRate.AddSalEncRate(salEncRateDto), CommonConstants.SUCCESS));		
		}

		[HttpPost("update-salEncRate")]
		public async Task<IActionResult> UpdateSalEncRate([FromBody] SalEncRateDto salEncRateDto)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _salEncRate.UpdateSalEncRate(salEncRateDto), CommonConstants.SUCCESS));
		}
		[HttpDelete("delete-salEncRate")]
		public async Task<IActionResult> DeleteSalEncRate(string EncVal)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _salEncRate.DeleteSalEncRate(EncVal), CommonConstants.SUCCESS));
		}
	}
}
