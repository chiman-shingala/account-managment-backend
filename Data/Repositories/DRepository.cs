using Acc.Data.Repository.Interface;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using static Dapper.SqlMapper;

namespace Acc.Data.Repositories
{
	public class DRepository : IDRepository, IDisposable
	{
		private readonly IDbConnection conn;
		public DRepository(IConfiguration configuration)
		{
			var connectionString = configuration.GetConnectionString("AccountSystem");
			conn = new SqlConnection(connectionString);
		}
		public async Task<string> GetString(string storeProc, object? param = null)
		{
			return await conn.QueryFirstAsync<string>(storeProc, param, commandType: CommandType.StoredProcedure).ConfigureAwait(false);
		}

		public async Task<string> GetStringByDynamicQuery(string query, object? param = null)
		{
			return await conn.QueryFirstAsync<string>(query, param, commandType: CommandType.Text).ConfigureAwait(false);
		}

		public async Task<T?> GetFirstOrDefault<T>(string storeProc, object? param = null)
		{
			var result = await conn.QueryAsync<T>(storeProc, param, commandType: CommandType.StoredProcedure).ConfigureAwait(false);
			return result.FirstOrDefault();
		}

		//this method is used in emailSender....this is created by Divy 18/07/2023...
		public async Task<T?> QueryFirstOrDefaultAsync<T>(string storeProc,object? param = null)
		{
			var result = await conn.QueryFirstOrDefaultAsync<T>(storeProc, param,commandType: CommandType.StoredProcedure);
			return result;
		}
		public async Task<T?> GetFirstOrDefaultByDynamicQuery<T>(string query, object? param = null)
		{
			var result = await conn.QueryAsync<T>(query, param, commandType: CommandType.Text).ConfigureAwait(false);
			return result.FirstOrDefault();
		}

		public async Task<List<T>> GetAll<T>(string storeProc, object? param = null)
		{
			var result = await conn.QueryAsync<T>(storeProc, param, commandType: CommandType.StoredProcedure).ConfigureAwait(false);
			return result.ToList();
		}

		public async Task<GridReader> QueryMultiple(string storeProc, object? param = null)
		{
			return await conn.QueryMultipleAsync(storeProc, param: param, commandType: CommandType.StoredProcedure).ConfigureAwait(false);
		}

		//public async Task<(List<T> Result, IDictionary<string, object> Output)> GetAllDictionary<T>(string storeProc, object param = null, IDictionary<string, object> output = null)
		//{
		//	var parameters = new DynamicParameters(param);
		//	foreach (var item in output ?? new Dictionary<string, object>())
		//		parameters.Add(item.Key, dbType: (DbType)item.Value, direction: ParameterDirection.Output);
		//	var result = await conn.QueryAsync<T>(storeProc, parameters, commandType: CommandType.StoredProcedure).ConfigureAwait(false);
		//	foreach (var key in new List<string>((output ?? new Dictionary<string, object>()).Keys))
		//		output[key] = parameters.Get<object>(key);
		//	return (result.ToList(), output);
		//}

		public async Task<List<T>> GetAllByDynamicQuery<T>(string query, object? param = null)
		{
			var result = await conn.QueryAsync<T>(query, param, commandType: CommandType.Text).ConfigureAwait(false);
			return result.ToList();
		}

		public async Task<int> ExecuteAsyncQuery(string storeProc, object? param = null)
		{
			return await conn.ExecuteAsync(storeProc, param, commandType: CommandType.StoredProcedure).ConfigureAwait(false);
		}
		public async Task<T> ExecuteAsyncQueryWithOutputParameter<T>(string storeProc, Func<DynamicParameters, DynamicParameters> addParameters,string outputParamName)
		{
			var parameters = new DynamicParameters();
			parameters = addParameters(parameters);
			await conn.ExecuteAsync(storeProc, parameters, commandType: CommandType.StoredProcedure).ConfigureAwait(false);
			var outputValue = parameters.Get<T>(outputParamName);

			return outputValue;
		}
		public async Task<int> ExecuteAsyncDynamicQuery(string query, object? param = null)
		{
			return await conn.ExecuteAsync(query, param, commandType: CommandType.Text).ConfigureAwait(false);
		}
		public async Task<object?> GetScalar(string storeProc, object? param = null)
		{
			return await conn.ExecuteScalarAsync<object>(storeProc, param, commandType: CommandType.StoredProcedure).ConfigureAwait(false);
		}
		public async Task<T?> ExecuteScalarAsync<T>(string storeProc)
		{
			var result = await conn.ExecuteScalarAsync<T>(storeProc, commandType: CommandType.StoredProcedure).ConfigureAwait(false);
			return result;
		}

		public async Task<T?> ExecuteAsyncQueryWithJson<T>(string storeProc, string param)
		{
			var parameters = new DynamicParameters();
			parameters.Add("@jsonData", param, DbType.String, ParameterDirection.Input);
			//return await conn.ExecuteAsync(storeProc, parameters, commandType: CommandType.StoredProcedure).ConfigureAwait(false);
			var result = await conn.QuerySingleOrDefaultAsync<T>(storeProc, parameters, commandType: CommandType.StoredProcedure).ConfigureAwait(false);
			return result;
		}
		public async Task<T?> QuerySingleOrDefaultAsync<T>(string storedProcedure, object? param = null)
		{
			return await conn.QuerySingleOrDefaultAsync<T>(storedProcedure, param, commandType: CommandType.StoredProcedure).ConfigureAwait(false);
		}

		#region IDisposable Support

		private bool disposedValue = false; // To detect redundant calls

		protected virtual void Dispose(bool disposing)
		{
			if (!disposedValue)
			{
				if (disposing)
				{
					conn.Dispose();
				}
				disposedValue = true;
			}
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		#endregion
	}
}
