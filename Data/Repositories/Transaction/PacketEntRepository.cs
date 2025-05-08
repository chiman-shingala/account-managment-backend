using Acc.Data.Interfaces.ITransaction;
using Acc.Data.Repository.Interface;
using Acc.Shared.Dtos;
using Dapper;
using System.Data;

namespace Acc.Data.Repositories.Transaction
{
	public class PacketEntRepository : IPacketEntRepository
	{
		private readonly IDRepository _dRepository;

		public PacketEntRepository(IDRepository dRepository)
		{
			_dRepository = dRepository;
		}
		public async Task<int> AddPacketEnt(PktMastDto packetEnt)
		{
			var result = await _dRepository.ExecuteAsyncQuery("SP_TrnPacketEntSave", packetEnt);
			return result;
		}
		public async Task<int> UpdatePacketEnt(PktMastDto packetEnt)
		{
			var result = await _dRepository.ExecuteAsyncQuery("SP_TrnPacketEntSave", packetEnt);
			return result;
		}
		public async Task<int> DeletePacketEnt(string PId, string Comp_Code)
		{
			return await _dRepository.ExecuteAsyncQueryWithOutputParameter<int>("SP_TrnPacketEntDelete", parameters =>
			{
				parameters.Add("@PId", PId, DbType.String);
				parameters.Add("@Comp_Code", Comp_Code, DbType.String);
				parameters.Add("@Out", dbType: DbType.Int32, direction: ParameterDirection.Output);
				return parameters;
			}, "Out");
		}
		public async Task<int> PacketExists(string PId, string Comp_Code)
		{
			return await _dRepository.ExecuteAsyncQueryWithOutputParameter<int>("SP_TrnPacketExists", parameters =>
			{
				parameters.Add("@PId", PId, DbType.String);
				parameters.Add("@Comp_Code", Comp_Code, DbType.String);
				parameters.Add("@Out", dbType: DbType.Int32, direction: ParameterDirection.Output);
				return parameters;
			}, "Out");
		}
		public async Task<List<int>> UpdateCostCont(PktMastDto pktMastDto)
		{			
			var parameters = new DynamicParameters();
			parameters.Add("@PId", pktMastDto.PId);
			parameters.Add("@Comp_Code", pktMastDto.Comp_Code);
			parameters.Add("@DispUpd", "U");
			parameters.Add("@AcYear", pktMastDto.AcYear);
			return await _dRepository.GetAll<int>("SP_TrnPacketEntUpdateOrDispCost", parameters);
		}
		public async Task<int> FindNewPId(string Comp_Code)
		{
			return await _dRepository.ExecuteScalarAsyncQuery("SP_FindNewPid", new { Comp_Code });
		}
	}
}
