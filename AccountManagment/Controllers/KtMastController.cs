using Acc.Services.Common;
using Acc.Services.Interfaces;
using Acc.Shared.Dtos;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Acc.Api.Controllers
{
	[Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class KtMastController : ControllerBase
	{
		private readonly IKtMastService _ktMast;

		public KtMastController(IKtMastService ktMast)
		{
			_ktMast = ktMast;
		}
		[HttpGet("get-kt")]
		public async Task<IActionResult> GetAllKtMast()
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _ktMast.GetAllKtMast(), CommonConstants.SUCCESS));
		}
		[HttpPost("add-kt")]
		public async Task<IActionResult> AddKtMast([FromBody] KtMastDto ktMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _ktMast.AddKtMast(ktMast), CommonConstants.SUCCESS));
		}
		[HttpPost("update-kt")]
		public async Task<IActionResult> UpdateKtMast([FromBody] KtMastDto ktMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _ktMast.UpdateKtMast(ktMast), CommonConstants.SUCCESS));
		}
		[HttpDelete("delete-kt")]
		public async Task<IActionResult> DeleteKtMast([FromQuery] string Kt)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _ktMast.DeleteKtMast(Kt), CommonConstants.SUCCESS));
		}
	}
}
