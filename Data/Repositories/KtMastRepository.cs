using Acc.Data.Interfaces;
using Acc.Data.Repository.Interface;
using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Repositories
{
	public class KtMastRepository : IKtMastRepository
	{
		private readonly IDRepository _dRepository;

		public KtMastRepository(IDRepository dRepository)
		{
			_dRepository = dRepository;
		}
		public async Task<List<KtMastDto>> GetAllKtMast()
		{
			return await _dRepository.GetAll<KtMastDto>("SP_MastKtMastFill");
		}
		public async Task<int> AddKtMast(KtMastDto ktMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_KtMastSave", ktMast);
		}
		public async Task<int> UpdateKtMast(KtMastDto ktMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_KtMastSave", ktMast);
		}
		public async Task<int> DeleteKtMast(string Kt)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_UtilKtMastDel", new { Kt });
		}
	}
}
