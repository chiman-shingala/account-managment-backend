using Acc.Data.Interfaces;
using Acc.Data.Repository.Interface;
using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Repositories
{
	public class PersonMastRepository : IPersonMastRepository
	{
		private readonly IDRepository _dRepository;

		public PersonMastRepository(IDRepository dRepository)
		{
			_dRepository = dRepository;
		}
		public async Task<List<PersonMastDto>> GetAllPerson(int AcYear,string Comp_Code)
		{
			return await _dRepository.GetAll<PersonMastDto>("SP_MastPersonMastFill", new {AcYear,Comp_Code});
		}
		public async Task<int> AddPerson(PersonMastDto personMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_PersonMastSave", personMast);
		}
		public async Task<int> UpdatePerson(PersonMastDto personMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_PersonMastSave", personMast);
		}
		public async Task<int> DeletePerson(string Pr_Code,int AcYear,string Comp_Code)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_UtilPersonMastDel", new { Pr_Code,AcYear,Comp_Code });
		}
	}
}
