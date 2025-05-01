using Acc.Data.Interfaces.IMaster;
using Acc.Services.Interfaces.Master;
using Acc.Shared.Dtos;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Services.Master
{
	public class TaskMastService : ITaskMastService
	{
		private readonly ITaskMastRepository _taskMast;

		public TaskMastService(ITaskMastRepository taskMast)
		{
			_taskMast = taskMast;
		}
		public async Task<List<TaskMastDto>> GetAllTaskMast(string UserID)
		{
			return await _taskMast.GetAllTaskMast(UserID);
		}
		public async Task<int> GetNewTaskID(string UserId)
		{
			return await _taskMast.GetNewTaskID(UserId);
		}
		public async Task<int> AddTaskMast(TaskMastDto taskMast)
		{
			return await _taskMast.AddTaskMast(taskMast);
		}
		public async Task<int> UpdateTaskMast(TaskMastDto taskMast)
		{
			return await _taskMast.UpdateTaskMast(taskMast);
		}
		public async Task<int> DeleteTaskMast(int TaskId, string UserId)
		{
			return await _taskMast.DeleteTaskMast(TaskId, UserId);
		}
	}
}
