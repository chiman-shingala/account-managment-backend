using Acc.Services.Common;
using Acc.Services.Interfaces;
using Acc.Shared.Dtos;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Acc.Api.Controllers.Master
{
	[Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class StonNatController : ControllerBase
	{
		private readonly IStonNatService _stonNat;

		public StonNatController(IStonNatService stonNat)
		{
			_stonNat = stonNat;
		}
		[HttpGet("get-stone")]
		public async Task<IActionResult> GetAllStone()
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _stonNat.GetAllStone(), CommonConstants.SUCCESS));
		}
		[HttpPost("add-stone")]
		public async Task<IActionResult> AddStone([FromBody] StonNatDto stonNat)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _stonNat.AddStone(stonNat), CommonConstants.SUCCESS));
		}
		[HttpPost("update-stone")]
		public async Task<IActionResult> UpdateStone([FromBody] StonNatDto stonNat)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _stonNat.UpdateStone(stonNat), CommonConstants.SUCCESS));
		}
		[HttpDelete("delete-stone")]
		public async Task<IActionResult> DeleteStone([FromQuery] string SN_Code)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _stonNat.DeleteStone(SN_Code), CommonConstants.SUCCESS));
		}
	}
}
