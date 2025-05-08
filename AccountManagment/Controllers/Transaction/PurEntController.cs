using Acc.Services.Common;
using Acc.Services.Interfaces.Transaction;
using Acc.Shared.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Acc.Api.Controllers.Transaction
{
	[Route("api/[controller]")]
	[ApiController]
	[Authorize]
	public class PurEntController : ControllerBase
	{
		private readonly IPurEntService _purEntService;

		public PurEntController(IPurEntService purEntService)
		{
			_purEntService = purEntService;
		}
		[HttpPost("save-sum")]
		public async Task<IActionResult> AddSum(PBillHDto pBillHDto)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK,await _purEntService.AddSum(pBillHDto), CommonConstants.SUCCESS));
		}
		[HttpPost("save-purchaseEntry")]
		public async Task<IActionResult> SavePurchaseAsync(SavePurchaseRequestDto requestDto)
		{
			var result = await _purEntService.SavePurchaseAsync(requestDto);			
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, result,CommonConstants.SUCCESS));
		}
		[HttpDelete("delete-purchaseEntry")]
		public async Task<IActionResult> DeletePurchase([FromQuery] int TrnNo,int AcYear,string Comp_Code)
		{
			var result = await _purEntService.DeletePurEnt(TrnNo,AcYear,Comp_Code);
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, result, CommonConstants.SUCCESS));
		}
	}
}
