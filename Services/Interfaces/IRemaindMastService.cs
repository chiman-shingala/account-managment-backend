using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Interfaces
{
	public interface IRemaindMastService
	{
		Task<List<RemaindMastDto>> GetAllRemaindMast();
		Task<int> AddRemaindMast(RemaindMastDto remaindMast);
		Task<int> UpdateRemaindMast(RemaindMastDto remaindMast);
		Task<int> DeleteRemaindMast(string Rem_Code);
	}
}
