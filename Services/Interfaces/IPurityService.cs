using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Interfaces
{
	public interface IPurityService
	{
		Task<List<QuaMastDto>> GetAllPurity();
		Task<int> AddPurity(QuaMastDto quaMast);
		Task<int> UpdatePurity(QuaMastDto quaMast);
		Task<int> DeletePurity(short Q_Code);
	}
}
