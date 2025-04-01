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
builder.Services.AddScoped<IDRepository, DRepository>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IColMastRepository, ColMastRepository>();
builder.Services.AddScoped<IColMastService, ColMastService>();
builder.Services.AddScoped<ICutMastRepository, CutMastRepository>();
builder.Services.AddScoped<ICutMastService, CutMastService>();
builder.Services.AddScoped<IPurityMastRepository, PurityMastRepository>();
builder.Services.AddScoped<IPurityService, PurityService>();
builder.Services.AddScoped<IShpMastRepository, ShpMastRepository>();
builder.Services.AddScoped<IShpMastService, ShpMastService>();
builder.Services.AddScoped<ISizeMastRepository, SizeMastRepository>();
builder.Services.AddScoped<ISizeMastService, SizeMastService>();
builder.Services.AddScoped<IGrpMastRepository, GrpMastRepository>();
builder.Services.AddScoped<IGrpMastService, GrpMastService>();
builder.Services.AddScoped<IAccYearRepository, AccYearRepository>();
builder.Services.AddScoped<IAccYearService, AccYearService>();
builder.Services.AddScoped<IAGrpMastRepository, AGrpMastRepository>();
builder.Services.AddScoped<IAGrpMastService, AGrpMastService>();
builder.Services.AddScoped<ICurrMastRepository, CurrMastRepository>();
builder.Services.AddScoped<ICurrMastService, CurrMastService>();
builder.Services.AddScoped<ICompMastRepository, CompMastRepository>();
builder.Services.AddScoped<ICompMastService, CompMastService>();
builder.Services.AddScoped<IPktGroupRepository,PktGroupRepository>();
builder.Services.AddScoped<IPktGroupService, PktGroupService>();
builder.Services.AddScoped<IParMastRepository,ParMastRepository>();
builder.Services.AddScoped<IParMastService, ParMastService>();
builder.Services.AddScoped<IPCompMastRepository,PCompMastRepository>();
builder.Services.AddScoped<IPCompMastService,PCompMastService>();
builder.Services.AddScoped<ICertMastRepository,CertMastRepository>();
builder.Services.AddScoped<ICertMastService,CertMastService>();
builder.Services.AddScoped<IPersonMastRepository , PersonMastRepository>();
builder.Services.AddScoped<IPersonMastService , PersonMastService>();
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
