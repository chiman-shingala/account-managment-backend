using Acc.Services.Common;
using Dapper;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Windows.Markup;

namespace Acc.Shared.Common
{
	public class CommonMethods
	{
		private readonly IDbConnection _dbConnection;

		public CommonMethods(IDbConnection dbConnection)
		{
			_dbConnection = dbConnection;
		}
		public async Task<T?> SearchTextAsync<T>(string tableName, string searchColumns, string searchValues, string returnColumn)
		{
			if (string.IsNullOrEmpty(searchColumns) || string.IsNullOrEmpty(searchValues) || string.IsNullOrEmpty(returnColumn))
				return default;

			string[] columns = searchColumns.Split(',');
			string[] values = searchValues.Split(',');

			if (columns.Length != values.Length)
				throw new ArgumentException("Mismatch between search columns and values.");

			string whereClause = string.Join(" AND ", columns.Select((col, i) => $"{col} = @param{i}"));

			string query = $"SELECT {returnColumn} FROM {tableName} WHERE {whereClause}";

			var parameter = new DynamicParameters();
			for (int i = 0; i < values.Length; i++)
			{
				parameter.Add($"param{i}", values[i]);
			}
			var result = await _dbConnection.QueryFirstOrDefaultAsync<T>(query, parameter);	
			return result;
		}
		public async Task<T?> SearchText<T>(string tableName, string condition, string returnColumn, int recordIndex = 0)
		{
			if (string.IsNullOrWhiteSpace(tableName) || string.IsNullOrWhiteSpace(condition) || string.IsNullOrWhiteSpace(returnColumn))
				return default;

			string query = $"SELECT {returnColumn} FROM {tableName} WHERE {condition}";

			var results = await _dbConnection.QueryAsync<T>(query);

			return results.Skip(recordIndex).FirstOrDefault();
		}
		public static double ToDouble(String pStr)
		{
			double dblVal;

			if (pStr == null || pStr.Length == 0)
			{
				return 0;
			}
			double.TryParse(pStr, out dblVal);
			return dblVal;
		}
	}
}
