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
	public class AGrpMastController : ControllerBase
	{
		private readonly IAGrpMastService _aGrpMast;

		public AGrpMastController(IAGrpMastService aGrpMast)
		{
			_aGrpMast = aGrpMast;
		}
		[HttpGet("get-agrp")]
		public async Task<IActionResult> GetAllAgrp()
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _aGrpMast.GetAllAGrp(), CommonConstants.SUCCESS));
		}
		[HttpGet("get-newAGrpCode")]
		public async Task<IActionResult> NewIdAGrpMast()
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _aGrpMast.NewIdAGrpMast(), CommonConstants.SUCCESS));
		}
		[HttpPost("add-agrp")]
		public async Task<IActionResult> AddAGrp([FromBody] AGrpMastDto aGrpMast)
		{
			if(aGrpMast.Agr_Code == 0)
			{
				return new JsonResult(new ApiResponse(true, HttpStatusCode.BadRequest, null, "Account Group Is Required"));
			}
			if(string.IsNullOrWhiteSpace(aGrpMast.Agr_Name))
			{
				return new JsonResult(new ApiResponse(true, HttpStatusCode.BadRequest, null, "Account Group Name Is Required"));
			}
			if (aGrpMast.Gr_Type == 0)
			{
				return new JsonResult(new ApiResponse(true, HttpStatusCode.BadRequest, null, "Group Type Is Required"));
			}
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _aGrpMast.AddAGrp(aGrpMast), CommonConstants.SUCCESS));
		}
		[HttpPost("update-agrp")]
		public async Task<IActionResult> UpdateAGrp([FromBody] AGrpMastDto aGrpMast)
		{
			if (aGrpMast.Agr_Code == 0)
			{
				return new JsonResult(new ApiResponse(true, HttpStatusCode.BadRequest, null, "Account Group Is Required"));
			}
			if (string.IsNullOrWhiteSpace(aGrpMast.Agr_Name))
			{
				return new JsonResult(new ApiResponse(true, HttpStatusCode.BadRequest, null, "Account Group Name Is Required"));
			}
			if (aGrpMast.Gr_Type == 0)
			{
				return new JsonResult(new ApiResponse(true, HttpStatusCode.BadRequest, null, "Group Type Is Required"));
			}
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _aGrpMast.UpdateAGrp(aGrpMast), CommonConstants.SUCCESS));
		}
		[HttpDelete("delete-agrp")]
		public async Task<IActionResult> DeleteAGrp([FromQuery] int AGR_Code)
		{
			var result = await _aGrpMast.DeleteAGrp(AGR_Code);
			if (result == 1)
			{
				return new JsonResult(new ApiResponse(false, HttpStatusCode.BadRequest, null, "Can't Delete System Group"));
			}
			else if (result == 2)
			{
				return new JsonResult(new ApiResponse(false, HttpStatusCode.BadRequest, null, "Other Group Exist Under This Group"));
			}else if (result == 0)
			{
				return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, "Record Deleted Succesfully", CommonConstants.SUCCESS));
			}
			else
				return new JsonResult(new ApiResponse(false, HttpStatusCode.InternalServerError, null, "An unexpected error occurred."));
		}
		[HttpGet("get-grType")]
		public async Task<IActionResult> GetGrpType()
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _aGrpMast.GetGrpType(), CommonConstants.SUCCESS));
		}
	}
}
