using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Common
{
	public static class JwtTokenHelper
	{		
		public static string GenerateToken(string userId, IConfiguration configuration)
		{
			var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]));
			var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
			var claims = new[]
			{
				new Claim(JwtRegisteredClaimNames.Sub,userId),
				new Claim(ClaimTypes.Name,userId),
				new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())

			};
			var token = new JwtSecurityToken(
				issuer:configuration["Jwt:Issuer"],
				audience:configuration["Jwt:Audience"],
				claims:claims,
				expires: DateTime.Now.AddHours(2),
				signingCredentials: credentials);


			return new JwtSecurityTokenHandler().WriteToken(token);

		}
		public static string? GetClaimValue(HttpContext httpContext, string claimType)
		{
			if (httpContext == null || !httpContext.Request.Headers.ContainsKey("Authorization"))
				throw new UnauthorizedAccessException("Authorization header is missing.");

			var token = httpContext.Request.Headers["Authorization"].ToString().Replace("Bearer ", "");

			var jwtToken = new JwtSecurityTokenHandler().ReadJwtToken(token);
			var claim = jwtToken.Claims.FirstOrDefault(c => c.Type == claimType);

			return claim?.Value;
		}
	}
}
