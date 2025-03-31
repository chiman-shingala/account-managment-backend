using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Acc.Shared.Dtos
{
	public class ChangePasswordDto
	{
		public string? UserId { get; set; }
		public string? Password { get; set; }
	}
}
