using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Common
{
	public class ApiResponse
	{
		[DataMember]
		public bool IsSuccess { get; set; }

		[DataMember]
		public int StatusCode { get; set; }

		[DataMember(EmitDefaultValue = false)]
		public string? Message { get; set; }

		[DataMember(EmitDefaultValue = false)]
		public object? Data { get; set; }
		public ApiResponse(bool isSuccess, HttpStatusCode statusCode, object? result = null, string? errorMessage = null)
		{
			IsSuccess = isSuccess;
			StatusCode = (int)statusCode;
			Data = result;
			Message = errorMessage;
		}
	}
}
