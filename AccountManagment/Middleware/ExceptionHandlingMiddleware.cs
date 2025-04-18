using Acc.Services.Common;
using Acc.Shared.Dtos;
using System.Net;
using System.Text.Json;

public class ExceptionHandlingMiddleware
{
	private readonly RequestDelegate _next;
	private readonly ILogger<ExceptionHandlingMiddleware> _logger;
	private readonly IWebHostEnvironment _env;

	public ExceptionHandlingMiddleware(RequestDelegate next, ILogger<ExceptionHandlingMiddleware> logger, IWebHostEnvironment env)
	{
		_next = next;
		_logger = logger;
		_env = env;
	}

	public async Task InvokeAsync(HttpContext context)
	{
		try
		{
			await _next(context);
		}
		catch (Exception ex)
		{
			_logger.LogError(ex, "An unhandled exception occurred");

			context.Response.ContentType = "application/json";
			context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

			var message = _env.IsDevelopment() ? ex.Message : "Something went wrong. Please try again later.";

			var response = new ApiResponse(
				isSuccess: false,
				statusCode: HttpStatusCode.InternalServerError,
				result: null,
				errorMessage: message
			);

			await context.Response.WriteAsync(JsonSerializer.Serialize(response));
		}
	}
}
