using Acc.Data.Interfaces.IRapaport;
using Acc.Data.Repository.Interface;
using Acc.Shared.Dtos;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Repositories.Rapaport
{
	public class RapaportRepository : IRapaportRepository
	{
		private readonly IDRepository _dRepository;

		public RapaportRepository(IDRepository dRepository)
		{
			_dRepository = dRepository;
		}
		public async Task<double> FindRap(string sCode, int qCode, int cCode, int szCode)
		{
			if (qCode == 0 || cCode == 0 || string.IsNullOrEmpty(sCode) || szCode == 0)
				return 0;

			if (qCode == -1)
				qCode = 1;

			var parameters = new DynamicParameters();
			parameters.Add("TableName", "RAPAPORT");
			parameters.Add("SZ_Code", szCode);
			parameters.Add("C_Code", cCode);
			parameters.Add("S_Code", sCode);

			var result = await _dRepository.QueryFirstOrDefaultAsync<dynamic>("Sp_FindRap", parameters);
			if(result != null && qCode <= 11)
			{
				string columnName = $"Q{qCode}";
				return Convert.ToDouble(result[columnName]);
			}
			return 0;
		}
		public async Task<double> FindDisc(string sCode, int qCode, int cCode, int szCode)
		{
			if (qCode == 0 || cCode == 0 || string.IsNullOrEmpty(sCode) || szCode == 0)
				return 0;
			if (qCode == -1)
				qCode = 1;
			var parameters = new DynamicParameters();
			parameters.Add("TableName", "RapDisc");
			parameters.Add("SZ_Code", szCode);
			parameters.Add("C_Code", cCode);
			parameters.Add("S_Code", sCode);
			var result = await _dRepository.QueryFirstOrDefaultAsync<dynamic>("Sp_FindRap", parameters);
			if (result != null && qCode <= 11)
			{
				string columnName = $"Q{qCode}";
				return Convert.ToDouble(result[columnName]);
			}
			return 0;
		}
		public async Task<double> FindFluoDisc(string sCode, int qCode, int cCode, int szCode,int flCode)
		{
			if (qCode == 0 || cCode == 0 || string.IsNullOrEmpty(sCode) || szCode == 0)
				return 0;
			if (qCode == -1)
				qCode = 1;
			var parameters = new DynamicParameters();
			parameters.Add("SZ_Code", szCode);
			parameters.Add("C_Code", cCode);
			parameters.Add("S_Code", sCode);
			parameters.Add("FL_Code", flCode);
			var result = await _dRepository.QueryFirstOrDefaultAsync<dynamic>("SP_FindFluoDisc", parameters);
			if (result != null && qCode <= 11)
			{
				string columnName = $"Q{qCode}";
				return Convert.ToDouble(result[columnName]);
			}
			return 0;
		}
		public async Task<double> FindCutDisc(string sCode, int qCode, int cCode, int szCode,int ctCode)
		{
			if (qCode == 0 || cCode == 0 || string.IsNullOrEmpty(sCode) || szCode == 0)
				return 0;
			if (qCode == -1)
				qCode = 1;
			var parameters = new DynamicParameters();
			parameters.Add("SZ_Code", szCode);
			parameters.Add("C_Code", cCode);
			parameters.Add("S_Code", sCode);
			parameters.Add("CT_Code", ctCode);
			var result = await _dRepository.QueryFirstOrDefaultAsync<dynamic>("SP_FindCutDisc", parameters);
			if (result != null && qCode <= 11)
			{
				string columnName = $"Q{qCode}";
				return Convert.ToDouble(result[columnName]);
			}
			return 0;
		}
		public async Task<List<RapaportDto>> GetAllRapaport(int SZ_Code ,string S_Code)
		{
			return await _dRepository.GetAll<RapaportDto>("SP_RapaportFill",new {SZ_Code,S_Code});
		}
		public async Task<int> AddRapaport(InsertRapaportDto rapaportDto)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_RapaportSave", rapaportDto);
		}
		public async Task<int> UpdateRapaport(InsertRapaportDto rapaportDto)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_RapaportSave", rapaportDto);
		}
	}
}
