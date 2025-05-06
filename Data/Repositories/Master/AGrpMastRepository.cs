using Acc.Data.Interfaces.IMaster;
using Acc.Data.Repository.Interface;
using Acc.Shared.Dtos;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Repositories.Master
{
	public class AGrpMastRepository : IAGrpMastRepository
	{
		private readonly IDRepository _dRepository;

		public AGrpMastRepository(IDRepository dRepository)
		{
			_dRepository = dRepository;
		}
		public async Task<List<AGrpMastDto>> GetAllAGrp()
		{
			return await _dRepository.GetAll<AGrpMastDto>("SP_MastAGrpMastFill");
		}
		public async Task<int> NewIdAGrpMast()
		{
			var newId =  await _dRepository.ExecuteScalarAsync<int>("SP_NewIdAGrpMast");
			return newId;
		}
		public async Task<int> AddAGrp(AGrpMastDto aGrpMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_AGrpMastSave", aGrpMast);
		}
		public async Task<int> UpdateAGrp(AGrpMastDto aGrpMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_AGrpMastSave", aGrpMast);
		}
		public async Task<int> DeleteAGrp(int AGR_Code)
		{
			return await _dRepository.ExecuteAsyncQueryWithOutputParameter<int>("SP_AGrpMastDel", parameters =>
			{
				parameters.Add("@AGR_Code", AGR_Code, DbType.Int32);
				parameters.Add("@Out", dbType: DbType.Int32, direction: ParameterDirection.Output);
				return parameters;
			},"@Out");
		}
		public async Task<List<GRTypeDto>> GetGrpType()
		{
			return await _dRepository.GetAll<GRTypeDto>("SP_GrpTypeDisp");
		}
	}
}
