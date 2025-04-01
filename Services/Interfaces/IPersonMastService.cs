using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Interfaces
{
	public interface IPersonMastService
	{
		Task<List<PersonMastDto>> GetAllPerson(int AcYear, string Comp_Code);
		Task<int> AddPersonMast(PersonMastDto personMast);
		Task<int> UpdatePersonMast(PersonMastDto personMast);
		Task<int> DeletePerson(string Pr_Code, int AcYear, string Comp_Code);
	}
}
