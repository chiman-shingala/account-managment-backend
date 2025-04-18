using Acc.Data.Interfaces.IUtility;
using Acc.Services.Interfaces.Utility;
using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Services.Utility
{
	public class PerMastService : IPerMastService
	{
		private readonly IPerMastRepository _perMast;

		public PerMastService(IPerMastRepository perMast)
		{
			_perMast = perMast;
		}
		public async Task<List<PerMastDto>> GetAllPerMast(string User_Name)
		{
			return await _perMast.GetAllPerMast(User_Name);
		}
		public async Task<List<PerMastDto>> GetUserWiseMenu(string User_Name)
		{
			return await _perMast.GetUserWiseMenu(User_Name);
		}
		public async Task<int> AddPerMast(PerMastDto perMast)
		{
			return await _perMast.AddPerMast(perMast);
		}
		public async Task<int> UpdatePerMast(PerMastDto perMast)
		{
			return await _perMast.UpdatePerMast(perMast);
		}
		public async Task<int> DeletePerMast(string USER_NAME, string FORM_NAME)
		{
			return await _perMast.DeletePerMast(USER_NAME, FORM_NAME);
		}
	}
}
