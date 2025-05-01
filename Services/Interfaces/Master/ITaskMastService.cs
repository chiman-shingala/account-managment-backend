using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Interfaces.Master
{
	public interface ITaskMastService
	{
		Task<List<TaskMastDto>> GetAllTaskMast(string UserID);
		Task<int> GetNewTaskID(string UserId);
		Task<int> AddTaskMast(TaskMastDto taskMast);
		Task<int> UpdateTaskMast(TaskMastDto taskMast);
		Task<int> DeleteTaskMast(int TaskId, string UserId);
	}
}
