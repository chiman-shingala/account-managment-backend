using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Shared.Dtos
{
	public class TaskMastDto
	{
		public int TaskId { get; set; }

		public string UserId { get; set; } = null!;

		public string? Task { get; set; }

		public DateTime? StartDate { get; set; }

		public DateTime? EndDate { get; set; }

		public string? Remark { get; set; }

		public bool? IsComplete { get; set; }

		public DateTime? TrnDate { get; set; }
	}
}
