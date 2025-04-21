using Acc.Services.Common;
using Acc.Services.Interfaces.Transaction;
using Acc.Shared.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Acc.Api.Controllers.Transaction
{
	[Route("api/[controller]")]
	[ApiController]
	public class PacketOpnController : ControllerBase
	{
		private readonly IPacketOpnService _packetOpn;

		public PacketOpnController(IPacketOpnService packetOpn)
		{
			_packetOpn = packetOpn;
		}
		[HttpGet("get-PacketOpn")]
		public async Task<IActionResult> GetPacketOpn(string PId, string Comp_Code, string Oper, int AcYear)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _packetOpn.GetPacketOpn(PId,Comp_Code,Oper,AcYear), CommonConstants.SUCCESS));
		}
		[HttpPost("add-PacketOpn")]
		public async Task<IActionResult> AddPacketOpn([FromBody] PktOpnDto pktOpn)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _packetOpn.AddPacketOpn(pktOpn), CommonConstants.SUCCESS));		
		}
		[HttpPost("update-PacketOpn")]
		public async Task<IActionResult> UpdatePacketOpn([FromBody] PktOpnDto pktOpn)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _packetOpn.UpdatePacketOpn(pktOpn), CommonConstants.SUCCESS));
		}
	}
}
