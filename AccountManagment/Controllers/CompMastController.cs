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
	public class CompMastController : ControllerBase
	{
		private readonly ICompMastService _compMast;

		public CompMastController(ICompMastService compMast)
		{
			_compMast = compMast;
		}
		[HttpGet("get-company")]
		public async Task<IActionResult> GetAllCompany([FromQuery] string? UserId = null)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _compMast.GetAllCompany(UserId ?? string.Empty), CommonConstants.SUCCESS));
		}
		[HttpPost("add-company")]
		public async Task<IActionResult> AddCompany([FromBody] CompMastDto compMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _compMast.AddCompany(compMast), CommonConstants.SUCCESS));
		}
		[HttpPost("update-company")]
		public async Task<IActionResult> UpdateCompany([FromBody] CompMastDto compMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _compMast.UpdateCompany(compMast), CommonConstants.SUCCESS));
		}
		[HttpDelete("delete-company")]
		public async Task<IActionResult> DeleteCompany([FromQuery] string Comp_Code)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _compMast.DeleteCompany(Comp_Code), CommonConstants.SUCCESS));
		}
	}
}
