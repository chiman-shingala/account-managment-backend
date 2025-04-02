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
	public class PropertyMastController : ControllerBase
	{
		private readonly IPropertyMastService _propertyMast;

		public PropertyMastController(IPropertyMastService propertyMast)
		{
			_propertyMast = propertyMast;
		}
		[HttpGet("get-property")]
		public async Task<IActionResult> GetAllPropertyMast()
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _propertyMast.GetAllPropertyMast(), CommonConstants.SUCCESS));
		}
		[HttpPost("add-Property")]
		public async Task<IActionResult> AddPropertyMast([FromBody] PropertyMastDto propertyMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _propertyMast.AddPropertyMastMast(propertyMast), CommonConstants.SUCCESS));
		}
		[HttpPost("update-Property")]
		public async Task<IActionResult> UpdatePropertyMast([FromBody] PropertyMastDto propertyMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _propertyMast.UpdatePropertyMastMast(propertyMast), CommonConstants.SUCCESS));
		}
		[HttpDelete("delete-Property")]
		public async Task<IActionResult> DeletePropertyMast([FromQuery] string PropId)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _propertyMast.DeletePropertyMast(PropId), CommonConstants.SUCCESS));
		}
	}
}
