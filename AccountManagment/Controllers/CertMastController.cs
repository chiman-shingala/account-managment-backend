using Acc.Services.Common;
using Acc.Services.Interfaces;
using Acc.Shared.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Acc.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CertMastController : ControllerBase
	{
		private readonly ICertMastService _certMast;

		public CertMastController(ICertMastService certMast)
		{
			_certMast = certMast;
		}
		[HttpGet("get-certificateDetail")]
		public async Task<IActionResult> GetAllCert()
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _certMast.GetAllCert(), CommonConstants.SUCCESS));
		}
		[HttpPost("add-certificateDetail")]
		public async Task<IActionResult> AddCertMast([FromBody] CertMastDto certMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _certMast.AddCertMast(certMast), CommonConstants.SUCCESS));
		}
		[HttpPost("update-certificateDetail")]
		public async Task<IActionResult> UpdateCertMast([FromBody] CertMastDto certMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _certMast.UpdateCertMast(certMast), CommonConstants.SUCCESS));
		}
		[HttpDelete("delete-certificateDetail")]
		public async Task<IActionResult> DeleteCut([FromQuery] short Cr_Code)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _certMast.DeleteCurrent(Cr_Code), CommonConstants.SUCCESS));
		}

	}
}
