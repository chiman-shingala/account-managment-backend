using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Interfaces
{
	public interface IPersonMastRepository
	{
		Task<List<PersonMastDto>> GetAllPerson(int AcYear, string Comp_Code);
		Task<int> AddPerson(PersonMastDto personMast);
		Task<int> UpdatePerson(PersonMastDto personMast);
		Task<int> DeletePerson(string Pr_Code, int AcYear, string Comp_Code);
	}
}
