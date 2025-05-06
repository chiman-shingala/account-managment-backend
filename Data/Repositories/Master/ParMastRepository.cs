using Acc.Data.Interfaces.IMaster;
using Acc.Data.Repository.Interface;
using Acc.Shared.Dtos;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Repositories.Master
{
	public class ParMastRepository : IParMastRepository
	{
		private readonly IDRepository _dRepository;

		public ParMastRepository(IDRepository dRepository)
		{
			_dRepository = dRepository;
		}
		public async Task<List<ParMastDto>> GetAllParMast(ParMastFillDto parMastFill)
		{			
			return await _dRepository.GetAll<ParMastDto>("SP_MastParMastFill", parMastFill);
		}
		public async Task<int> AddParMast(ParMastSaveDto parMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_ParMastSave", parMast);
		}
		public async Task<int> UpdateParMast(ParMastSaveDto parMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_ParMastSave", parMast);
		}
		public async Task<int> DeleteParMast(string P_Code,int Acyear ,string Comp_Code)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_UtilParMastDel", new { P_Code,Acyear,Comp_Code });
		}
		public async Task<string> ParMastNextCode(string initChar, int acYear, string compCode)
		{
			var parameters = new DynamicParameters();
			parameters.Add("@InitCh", initChar);
			parameters.Add("@AcYear", acYear);
			parameters.Add("@Comp_Code", compCode);
			var result = await _dRepository.QueryFirstOrDefaultAsync<string>("sp_ParMastNextCode",parameters);

			return result;
		}
	}
}
