using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
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
				new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
				
			};
			var token = new JwtSecurityToken(configuration["Jwt:Issuer"],
				configuration["Jwt:Audience"],
				claims,
				expires: DateTime.Now.AddMinutes(15),
				signingCredentials: credentials);


			return new JwtSecurityTokenHandler().WriteToken(token);

		}
	}
}
