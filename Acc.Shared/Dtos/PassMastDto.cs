using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Acc.Services.Dtos
{
	public class PassMastDto
	{
		public string UserId { get; set; } = null!;

		public string? Password { get; set; }
		[JsonPropertyName("cat")]
		public string? Category { get; set; }
	}
}
