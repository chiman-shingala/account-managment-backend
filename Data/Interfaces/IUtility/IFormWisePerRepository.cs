using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Interfaces.IUtility
{
	public interface IFormWisePerRepository
	{
		Task<List<PerMastDto>> GetAllFormWisePer(string Form_Name);
		Task<List<PerMastDto>> GetAllFormPer(string User_Name);
	}
}
