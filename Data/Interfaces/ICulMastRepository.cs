using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Interfaces
{
	public interface ICulMastRepository
	{
		Task<string?> GetCulPer(int pintCUCode);
	}
}
