using Acc.Api.Extensions;
using Acc.Data.Interfaces;
using Acc.Data.Repositories;
using Acc.Data.Repository.Interface;
using Acc.Services.Interfaces;
using Acc.Services.Services;
using Data.Interfaces;
using Data.Models;
using Data.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Scalar.AspNetCore;
using Services.Interfaces;
using Services.Services;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options => {
	options.TokenValidationParameters = new TokenValidationParameters
	{
		ValidateIssuer = true,
		ValidateAudience = true,
		ValidateLifetime = true,
		ValidateIssuerSigningKey = true,
		ValidIssuer = builder.Configuration["Jwt:Issuer"],
		ValidAudience = builder.Configuration["Jwt:Audience"],
		IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
	};
});
builder.Services.AddSwaggerGen(opt =>
{
	opt.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
	{
		BearerFormat = "JWT",
		Description = "JWT Authorization header using the Bearer scheme.",
		Name = "Authorization",
		In = ParameterLocation.Header,
		Type = SecuritySchemeType.Http,
		Scheme = "Bearer"
	});
	opt.AddSecurityRequirement(new OpenApiSecurityRequirement
			{
				{
					new OpenApiSecurityScheme
					{
						Reference = new OpenApiReference
						{
							Id = "Bearer",
							Type = ReferenceType.SecurityScheme
						}
					},
					Array.Empty<string>()
				}
			});
});

builder.Services.AddControllers();
builder.Services.AddDbContext<DratnaContext>(options =>
	options.UseSqlServer(builder.Configuration.GetConnectionString("AccountSystem")));
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.RegisterApplicationServices();
var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger(opt =>
{
	opt.RouteTemplate = "openapi/{documentName}.json";
});
app.MapScalarApiReference(opt =>
{
	opt.Title = "Account Managment";
	opt.Theme = ScalarTheme.BluePlanet;
	opt.DefaultHttpClient = new(ScalarTarget.Http, ScalarClient.Http11);
});

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
