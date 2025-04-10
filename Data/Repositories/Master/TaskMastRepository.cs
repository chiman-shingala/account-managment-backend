using Acc.Data.Interfaces.IMaster;
using Acc.Data.Repository.Interface;
using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Repositories.Master
{
	public class TaskMastRepository : ITaskMastRepository
	{
		private readonly IDRepository _dRepository;

		public TaskMastRepository(IDRepository dRepository)
		{
			_dRepository = dRepository;
		}
		public async Task<List<TaskMastDto>> GetAllTaskMast(string UserID)
		{
			return await _dRepository.GetAll<TaskMastDto>("SP_MastTaskMastFill", new { UserID });
		}
		public async Task<int> GetNewTaskID(string UserId)
		{
			var newId = await _dRepository.QuerySingleOrDefaultAsync<int>("SP_GetNewTaskID",new {UserId});
			return newId;
		}
		public async Task<int> AddTaskMast(TaskMastDto taskMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_TaskMastSave", taskMast);
		}
		public async Task<int> UpdateTaskMast(TaskMastDto taskMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_TaskMastSave", taskMast);
		}
		public async Task<int> DeleteTaskMast(int TaskId,int UserId)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_UtilTaskMastDel", new { TaskId,UserId });
		}
	}
}
