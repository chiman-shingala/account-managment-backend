using Acc.Services.Common;
using Acc.Services.Interfaces;
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
	public class PersonMastController : ControllerBase
	{
		private readonly IPersonMastService _personMast;

		public PersonMastController(IPersonMastService personMast)
		{
			_personMast = personMast;
		}
		[HttpGet("get-person")]
		public async Task<IActionResult> GetAllPerson(int AcYear, string Comp_Code)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _personMast.GetAllPerson(AcYear,Comp_Code), CommonConstants.SUCCESS));
		}
		[HttpPost("add-person")]
		public async Task<IActionResult> AddPerson([FromBody] PersonMastDto personMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _personMast.AddPersonMast(personMast), CommonConstants.SUCCESS));
		}
		[HttpPost("update-person")]
		public async Task<IActionResult> UpdatePerson([FromBody] PersonMastDto personMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _personMast.UpdatePersonMast(personMast), CommonConstants.SUCCESS));
		}
		[HttpDelete("delete-person")]
		public async Task<IActionResult> DeletePerson([FromQuery] string Pr_Code, int AcYear, string Comp_Code)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _personMast.DeletePerson(Pr_Code,AcYear,Comp_Code), CommonConstants.SUCCESS));
		}
	}
}
