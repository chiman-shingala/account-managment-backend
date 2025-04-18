using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Interfaces.Utility
{
	public interface IFormWisePerService
	{
		Task<List<PerMastDto>> GetAllFormWisePer(string Form_Name);
	}
}
