using Acc.Services.Common;
using Acc.Services.Interfaces;
using Acc.Services.Services;
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
	public class DeptMastController : ControllerBase
	{
		private readonly IDeptMastService _deptMast;

		public DeptMastController(IDeptMastService deptMast)
		{
			_deptMast = deptMast;
		}
		[HttpGet("get-dept")]
		public async Task<IActionResult> GetAllDept()
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _deptMast.GetAllDeptMast(), CommonConstants.SUCCESS));
		}
		[HttpPost("add-dept")]
		public async Task<IActionResult> AddDept([FromBody] DeptMastDto deptMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _deptMast.AddDept(deptMast), CommonConstants.SUCCESS));
		}
		[HttpPost("update-dept")]
		public async Task<IActionResult> UpdateDept([FromBody] DeptMastDto deptMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _deptMast.UpdateDept(deptMast), CommonConstants.SUCCESS));
		}
		[HttpDelete("delete-dept")]
		public async Task<IActionResult> DeleteDept([FromQuery] string DP_Code)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _deptMast.DeleteDept(DP_Code), CommonConstants.SUCCESS));
		}
	}
}
