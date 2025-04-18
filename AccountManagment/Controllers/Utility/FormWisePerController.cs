using Acc.Services.Common;
using Acc.Services.Interfaces.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Acc.Api.Controllers.Utility
{
	[Route("api/[controller]")]
	[ApiController]
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
	}
}
