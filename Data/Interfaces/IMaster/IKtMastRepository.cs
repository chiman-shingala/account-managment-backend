using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Interfaces.IMaster
{
	public interface IKtMastRepository
	{
		Task<List<KtMastDto>> GetAllKtMast();
		Task<int> AddKtMast(KtMastDto ktMast);
		Task<int> UpdateKtMast(KtMastDto ktMast);
		Task<int> DeleteKtMast(string Kt);
	}
}
