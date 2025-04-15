using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Interfaces
{
	public interface IEFacMastRepository
	{
		Task<string?> GetEFacPer(int pintEFCode);
	}
}
