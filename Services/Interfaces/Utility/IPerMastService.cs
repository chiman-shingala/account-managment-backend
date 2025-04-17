using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Interfaces.Utility
{
	public interface IPerMastService
	{
		Task<List<PerMastDto>> GetAllPerMast(string User_Name);
		Task<List<PerMastDto>> GetUserWiseMenu(string User_Name);
		Task<int> AddPerMast(PerMastDto perMast);
		Task<int> UpdatePerMast(PerMastDto perMast);
		Task<int> DeletePerMast(string USER_NAME, string FORM_NAME);
	}
}
