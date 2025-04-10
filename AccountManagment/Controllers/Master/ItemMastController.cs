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
	public class ItemMastController : ControllerBase
	{
		private readonly IItemMastService _itemMast;

		public ItemMastController(IItemMastService itemMast)
		{
			_itemMast = itemMast;
		}
		[HttpGet("get-item")]
		public async Task<IActionResult> GetAllItem()
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _itemMast.GetAllItem(), CommonConstants.SUCCESS));
		}
		[HttpPost("add-item")]
		public async Task<IActionResult> AddItem([FromBody] ItemMastDto itemMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _itemMast.AddItem(itemMast), CommonConstants.SUCCESS));
		}
		[HttpPost("update-item")]
		public async Task<IActionResult> UpdateItem([FromBody] ItemMastDto itemMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _itemMast.UpdateItem(itemMast), CommonConstants.SUCCESS));
		}
		[HttpDelete("delete-item")]
		public async Task<IActionResult> DeleteItem([FromQuery] string I_Code)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _itemMast.DeleteItem(I_Code), CommonConstants.SUCCESS));
		}
	}
}
