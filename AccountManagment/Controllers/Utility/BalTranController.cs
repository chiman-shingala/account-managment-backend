using Acc.Services.Common;
using Acc.Services.Interfaces.Utility;
using Acc.Shared.Dtos;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Acc.Api.Controllers.Utility
{
	[Route("api/[controller]")]
	[ApiController]
	public class BalTranController : ControllerBase
	{
		private readonly IBalTranService _balTran;

		public BalTranController(IBalTranService balTran)
		{
			_balTran = balTran;
		}
		[HttpPost("StockTran")]
		public async Task<IActionResult> StockTran([FromBody] BalTranDto balTran)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _balTran.StockTran(balTran), "Stock Successfully Transfered"));			
		}
		[HttpPost("BalTran")]
		public async Task<IActionResult> BalTran([FromBody] BalTranDto balTran)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _balTran.BalTran(balTran), "Balance Successfully Transfered"));			
		}		
	}
}
