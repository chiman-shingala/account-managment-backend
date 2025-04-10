using Acc.Data.Interfaces.IMaster;
using Acc.Services.Interfaces;
using Acc.Shared.Dtos;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Services
{
	public class PersonMastService : IPersonMastService
	{
		private readonly IPersonMastRepository _personMast;

		public PersonMastService(IPersonMastRepository personMast)
		{
			_personMast = personMast;
		}
		public async Task<List<PersonMastDto>> GetAllPerson(int AcYear, string Comp_Code)
		{
			return await _personMast.GetAllPerson(AcYear,Comp_Code);
		}
		public async Task<int> AddPersonMast(PersonMastDto personMast)
		{
			return await _personMast.AddPerson(personMast);
		}
		public async Task<int> UpdatePersonMast(PersonMastDto personMast)
		{
			return await _personMast.UpdatePerson(personMast);
		}
		public async Task<int> DeletePerson(string Pr_Code, int AcYear, string Comp_Code)
		{
			return await _personMast.DeletePerson(Pr_Code, AcYear, Comp_Code);
		}
	}
}
