using Acc.Data.Interfaces.IMaster;
using Acc.Data.Repository.Interface;
using Acc.Shared.Dtos;
using Dapper;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Repositories.Master
{
	public class PCompMastRepository :IPCompMastRepository
	{
		private readonly IDRepository _dRepository;

		public PCompMastRepository(IDRepository dRepository)
		{
			_dRepository = dRepository;
		}		
		public async Task<int> AddPCompMast(PCompMastDto pCompMast)
		{
			var parameters = new DynamicParameters();
			parameters.Add("PComp_Code", pCompMast.Pcomp_Code);
			parameters.Add("PComp_Name", pCompMast.Pcomp_Name);
			parameters.Add("BType", pCompMast.Btype);
			parameters.Add("Person1", pCompMast.Person1);
			parameters.Add("Desg1", pCompMast.Desg1);
			parameters.Add("Mobile1", pCompMast.Mobile1);
			parameters.Add("Person2", pCompMast.Person2);
			parameters.Add("Desg2", pCompMast.Desg2);
			parameters.Add("Mobile2", pCompMast.Mobile2);
			parameters.Add("Add1", pCompMast.Add1);
			parameters.Add("Add2", pCompMast.Add2);
			parameters.Add("City", pCompMast.City);
			parameters.Add("State", pCompMast.State);
			parameters.Add("Country", pCompMast.Country);
			parameters.Add("Pin", pCompMast.Pin);
			parameters.Add("Phone1", pCompMast.Phone1);
			parameters.Add("Phone2", pCompMast.Phone2);
			parameters.Add("Fax", pCompMast.Fax);
			parameters.Add("Website", pCompMast.Website);
			parameters.Add("Email1", pCompMast.Email1);
			parameters.Add("Email2", pCompMast.Email2);
			parameters.Add("MOA", pCompMast.Moa);
			parameters.Add("BName", pCompMast.Bname);
			parameters.Add("BMobile", pCompMast.Bmobile);
			parameters.Add("BPhone", pCompMast.Bphone);
			parameters.Add("ChinName", pCompMast.ChinName);
			parameters.Add("ChinBD", pCompMast.ChinBd);
			parameters.Add("ChinAdd", pCompMast.ChinAdd);
			parameters.Add("SkypeId", pCompMast.SkypeId);
			parameters.Add("SkypePass", pCompMast.SkypePass);
			parameters.Add("Id", pCompMast.Id);
			parameters.Add("AcYear", pCompMast.AcYear);
			parameters.Add("Comp_Code", pCompMast.Comp_Code);

			parameters.Add("Bank", pCompMast.Bank);
			parameters.Add("AccNo", pCompMast.AccNo);
			parameters.Add("AccName", pCompMast.AccName);
			parameters.Add("SWCode", pCompMast.Swcode);

			return await _dRepository.ExecuteAsyncQuery("SP_PCompMastCompSave", parameters);
		}
		public async Task<int> UpdatePCompMast(PCompMastDto pCompMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_PCompMastCompSave", pCompMast);
		}
		public async Task<int> DeletePCompMast(string P_Code, int Acyear, string Comp_Code)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_PCompMastDel", new { P_Code,Acyear,Comp_Code });
		}


		// party detail save button implementation pending

		public async Task<int> SaveParMast(ParMastDto parMast)
		{
			var parameters = new DynamicParameters();
			parameters.Add("P_Code", parMast.P_Code);
			parameters.Add("P_Name", parMast.P_Name);
			parameters.Add("GR_Code", parMast.Gr_Code);
			parameters.Add("P_Type", parMast.P_Type);
			parameters.Add("OAmount", parMast.Oamount);
			parameters.Add("OAmountL", parMast.OamountL);
			parameters.Add("Remark", parMast.Remark);
			parameters.Add("Limit", parMast.Limit);
			parameters.Add("PTag", (byte[])parMast.Ptag);
			parameters.Add("PPhoto", (byte[])parMast.Pphoto);
			parameters.Add("AGR_Code", parMast.AGR_Code);
			parameters.Add("VatNo", parMast.VatNo);
			parameters.Add("CnCy", parMast.CnCy);
			parameters.Add("Conv", parMast.Conv);
			parameters.Add("AcYear", parMast.AcYear);
			parameters.Add("Comp_Code", parMast.Comp_Code);
			return await _dRepository.ExecuteAsyncQuery("SP_PCompMastParSave", parameters);
		}

		public async Task SaveParPersonsAsync(SaveParPersonRequestDto request)
		{
			foreach (var person in request.Persons)
			{
				person.AcYear = request.AcYear;
				person.Comp_Code = request.Comp_Code;

				if (person.State == "Deleted")
				{
					await DeleteParPersonAsync(person);
				}
				else if (person.State == "Added" || person.State == "Modified")
				{
					await SaveAssignParPersonAsync(person);
				}
			}
		}
		private async Task SaveAssignParPersonAsync(ParPersonDto person)
		{
			var parameters = new DynamicParameters();
			parameters.Add("P_Code", person.P_Code);
			parameters.Add("PR_Code", person.PR_Code);
			parameters.Add("AcYear", person.AcYear);
			parameters.Add("Comp_Code", person.Comp_Code);

			await _dRepository.ExecuteAsyncQuery("SP_PCompMastParPersonSave", parameters);
		}

		private async Task DeleteParPersonAsync(ParPersonDto person)
		{
			var parameters = new DynamicParameters();
			parameters.Add("P_Code", person.P_Code);
			parameters.Add("PR_Code", person.PR_Code);
			parameters.Add("AcYear", person.AcYear);
			parameters.Add("Comp_Code", person.Comp_Code);

			await _dRepository.ExecuteAsyncQuery("SP_PCompMastParPersonDel", parameters);
		}
	}
}
