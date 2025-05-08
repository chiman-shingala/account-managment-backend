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
	public class ParPktMastController : ControllerBase
	{
		private readonly IParPktMastService _parPktMast;

		public ParPktMastController(IParPktMastService parPktMast)
		{
			_parPktMast = parPktMast;
		}
		[HttpGet("get-parPkt")]
		public async Task<IActionResult> GetAllParPktMast([FromQuery] string Comp_Code)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _parPktMast.GetAllParPktMast(Comp_Code), CommonConstants.SUCCESS));
		}
		[HttpPost("add-parPkt")]
		public async Task<IActionResult> AddParPktMast([FromBody] ParPktMastDto parPktMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _parPktMast.AddParPktMast(parPktMast), CommonConstants.SUCCESS));
		}
		[HttpPost("update-parPkt")]
		public async Task<IActionResult> UpdateParPktMast([FromBody] ParPktMastDto parPktMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _parPktMast.UpdateParPktMast(parPktMast), CommonConstants.SUCCESS));
		}
		[HttpDelete("delete-parPkt")]
		public async Task<IActionResult> DeleteParPktMast([FromQuery] string ParPId, string Comp_Code)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _parPktMast.DeleteParPktMast(ParPId,Comp_Code), CommonConstants.SUCCESS));
		}
	}
}
