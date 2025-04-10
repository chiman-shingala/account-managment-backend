using Acc.Services.Common;
using Acc.Services.Interfaces;
using Acc.Shared.Dtos;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Acc.Api.Controllers.Transaction
{
	[Route("api/[controller]")]
	[ApiController]
	public class PacketEntController : ControllerBase
	{
		private readonly IPacketEntService _packetEntService;

		public PacketEntController(IPacketEntService packetEntService)
		{
			_packetEntService = packetEntService;
		}
		[HttpPost("find-rap-value")]
		public async Task<IActionResult> FindRapValue([FromBody] RapDetailsRequestDto request)
		{
			var result = await _packetEntService.GetRapDetailsAsync(request.Packet, request.Codes, request.ReturnDetail);
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, result, CommonConstants.SUCCESS));

		}
	}
}
