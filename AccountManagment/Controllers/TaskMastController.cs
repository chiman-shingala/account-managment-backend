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
	public class TaskMastController : ControllerBase
	{
		private readonly ITaskMastService _taskMast;

		public TaskMastController(ITaskMastService taskMast)
		{
			_taskMast = taskMast;
		}
		[HttpGet("get-task")]
		public async Task<IActionResult> GetAllTaskMast([FromQuery] string UserID)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _taskMast.GetAllTaskMast(UserID), CommonConstants.SUCCESS));
		}
		[HttpGet("get-newTaskId")]
		public async Task<IActionResult> GetNewTaskID([FromQuery]  string UserID)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _taskMast.GetNewTaskID(UserID), CommonConstants.SUCCESS));
		}
		[HttpPost("add-task")]
		public async Task<IActionResult> AddTaskMast([FromBody] TaskMastDto taskMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _taskMast.AddTaskMast(taskMast), CommonConstants.SUCCESS));
		}
		[HttpPost("update-task")]
		public async Task<IActionResult> UpdateTaskMast([FromBody] TaskMastDto taskMast)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _taskMast.UpdateTaskMast(taskMast), CommonConstants.SUCCESS));
		}
		[HttpDelete("delete-task")]
		public async Task<IActionResult> DeleteTaskMast([FromQuery] int TaskId, int UserId)
		{
			return new JsonResult(new ApiResponse(true, HttpStatusCode.OK, await _taskMast.DeleteTaskMast(TaskId,UserId), CommonConstants.SUCCESS));
		}
	}
}
