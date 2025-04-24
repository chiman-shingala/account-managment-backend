using Acc.Services.Common;
using Acc.Services.Interfaces.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Security.Claims;

namespace Acc.Api.Controllers.Utility
{
	[Route("api/[controller]")]
	[ApiController]
	[Authorize]

	public class FormWisePerController : ControllerBase
	{
		private readonly IFormWisePerService _formWisePer;

		public FormWisePerController(IFormWisePerService formWisePer)
		{
			_formWisePer = formWisePer;
		}
		[HttpGet("get-formWisePer")]                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        
		public async Task<IActionResult> GetFormWisePer(string Form_Name)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _formWisePer.GetAllFormWisePer(Form_Name), CommonConstants.SUCCESS));
		}
		[HttpGet("get-allformPer")]
		public async Task<IActionResult> GetAllFormWisePer()
		{
			var userName = User.FindFirst(ClaimTypes.Name)?.Value;
			//var userName = JwtTokenHelper.GetClaimValue(HttpContext, ClaimTypes.Name);
			if (string.IsNullOrEmpty(userName))
				return Unauthorized(new ApiResponse(false, HttpStatusCode.Unauthorized, null, "Username not found in token."));

			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _formWisePer.GetAllFormPer(userName), CommonConstants.SUCCESS));
		}
	}
}
