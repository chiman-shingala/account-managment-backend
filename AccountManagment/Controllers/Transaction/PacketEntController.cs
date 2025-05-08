using Acc.Services.Common;
using Acc.Services.Interfaces.Transaction;
using Acc.Shared.Dtos;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Acc.Api.Controllers.Transaction
{
	[Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class PacketEntController : ControllerBase
	{
		private readonly IPacketEntService _packetEntService;

		public PacketEntController(IPacketEntService packetEntService)
		{
			_packetEntService = packetEntService;
		}
		[HttpGet("get-allPacketEnt")]
		public async Task<IActionResult> GetAllPacketEnt([FromQuery] string PId, string Comp_Code)
		{
			var result = await _packetEntService.GetAllPacketEnt(PId, Comp_Code);
			if (result.Count > 0)
			{
				return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, result, CommonConstants.SUCCESS));
			}
			else
			{
				return new JsonResult(new ApiResponse(false, HttpStatusCode.BadRequest, null, CommonConstants.FAIL));
			}
		}

		[HttpPost("find-rapValue")]
		public async Task<IActionResult> FindRapValue([FromBody] RapDetailsRequestDto request)
		{
			var result = await _packetEntService.GetRapDetailsAsync(request.Packet, request.Codes, request.ReturnDetail);
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, result, CommonConstants.SUCCESS));

		}
		[HttpPost("add-packetEnt")]
		public async Task<IActionResult> AddPacketEnt([FromBody] PktMastDto packetEnt)
		{
			if(packetEnt.PId == string.Empty)
			{
				return new JsonResult(new ApiResponse(false, HttpStatusCode.BadRequest, null, "Packet Id Is Required"));
			}			
			var result = await _packetEntService.AddPacketEnt(packetEnt);
			if (result > 0)
			{
				return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, result, CommonConstants.SUCCESS));
			}
			else
			{
				return new JsonResult(new ApiResponse(false, HttpStatusCode.BadRequest, null, CommonConstants.FAIL));
			}
		}
		[HttpPost("update-packetEnt")]
		public async Task<IActionResult> UpdatePacketEnt([FromBody] PktMastDto packetEnt)
		{
			var result = await _packetEntService.UpdatePacketEnt(packetEnt);
			if (result > 0)
			{
				return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, result, CommonConstants.SUCCESS));
			}
			else
			{
				return new JsonResult(new ApiResponse(false, HttpStatusCode.BadRequest, null, CommonConstants.FAIL));
			}
		}
		[HttpDelete("delete-packetEnt")]
		public async Task<IActionResult> DeletePacketEnt(string PId, string Comp_Code)
		{
			var result = await _packetEntService.DeletePacketEnt(PId, Comp_Code);

			if (result == 0)
			{
				return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, result, CommonConstants.SUCCESS));
			}
			else if (result == 1)
			{
				return new JsonResult(new ApiResponse(false, HttpStatusCode.BadRequest, null, "Purchase Already Done For This Packet, Delete Record"));
			}
			else if (result == 2)
			{
				return new JsonResult(new ApiResponse(false, HttpStatusCode.BadRequest, null, "Sales Already Done For This Packet, Delete Record"));
			}
			else if (result == 3)
			{
				return new JsonResult(new ApiResponse(false, HttpStatusCode.BadRequest, null, "Consignment IN Already Done For This Packet, Delete Record"));
			}
			else if (result == 4)
			{
				return new JsonResult(new ApiResponse(false, HttpStatusCode.BadRequest, null, "Consignment OUT Already Done For This Packet, Delete Record"));
			}
			else if (result == 5)
			{
				return new JsonResult(new ApiResponse(false, HttpStatusCode.BadRequest, null, "Purchase Return Already Done For This Packet, Delete Record"));
			}
			else if (result == 6)
			{
				return new JsonResult(new ApiResponse(false, HttpStatusCode.BadRequest, null, "Sales Return Already Done For This Packet, Delete Record"));
			}
			else if (result == 7)
			{
				return new JsonResult(new ApiResponse(false, HttpStatusCode.BadRequest, null, "Stock Adjustment Already Done For This Packet, Delete Record"));
			}
			else if (result == 8)
			{
				return new JsonResult(new ApiResponse(false, HttpStatusCode.BadRequest, null, "Packet Stock Transfer Already Done For This Packet, Delete Record"));
			}
			else if (result == 9)
			{
				return new JsonResult(new ApiResponse(false, HttpStatusCode.BadRequest, null, "Packet Stock Transfer [Multi] Already Done For This Packet, Delete Record"));
			}
			else
			{
				return new JsonResult(new ApiResponse(false, HttpStatusCode.BadRequest, null, "Unknown error occurred while deleting the packet"));
			}
		}
		[HttpPost("find-newPId")]
		public async Task<IActionResult> FindNewPId([FromQuery] string Comp_Code)
		{
			var result = await _packetEntService.FindNewPId(Comp_Code);
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, result, CommonConstants.SUCCESS));

		}
		
	}
}
