using Acc.Data.Interfaces.IMaster;
using Acc.Services.Interfaces;
using Acc.Shared.Dtos;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Services
{
	public class KtMastService : IKtMastService
	{
		private readonly IKtMastRepository _ktMast;

		public KtMastService(IKtMastRepository ktMast)
		{
			_ktMast = ktMast;
		}
		public async Task<List<KtMastDto>> GetAllKtMast()
		{
			return await _ktMast.GetAllKtMast();
		}
		public async Task<int> AddKtMast(KtMastDto ktMast)
		{
			return await _ktMast.AddKtMast(ktMast);
		}
		public async Task<int> UpdateKtMast(KtMastDto ktMast)
		{
			return await _ktMast.UpdateKtMast(ktMast);
		}
		public async Task<int> DeleteKtMast(string Kt)
		{
			return await _ktMast.DeleteKtMast(Kt);
		}
	}
}
