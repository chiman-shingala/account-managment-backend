using Acc.Services.Common;
using Acc.Services.Interfaces;
using Acc.Shared.Dtos;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Acc.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PktGroupController : ControllerBase
	{
		private readonly IPktGroupService _pktGroup;

		public PktGroupController(IPktGroupService pktGroup)
		{
			_pktGroup = pktGroup;
		}
		[HttpGet("get-pktGroup")]
		public async Task<IActionResult> GetAllPktGroup()
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _pktGroup.GetAllPktGroup(), CommonConstants.SUCCESS));
		}
		[HttpPost("add-pktGroup")]
		public async Task<IActionResult> AddPktGroup([FromBody] PktGroupDto pktGroup)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _pktGroup.AddPktGroup(pktGroup), CommonConstants.SUCCESS));
		}
		[HttpPost("update-pktGroup")]
		public async Task<IActionResult> UpdatePktGroup([FromBody] PktGroupDto pktGroup)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _pktGroup.UpdatePktGroup(pktGroup), CommonConstants.SUCCESS));
		}
		[HttpDelete("delete-pktGroup")]
		public async Task<IActionResult> DeletePktGroup([FromQuery] string PG_Code)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _pktGroup.DeletePktGroup(PG_Code), CommonConstants.SUCCESS));
		}
	}
}
