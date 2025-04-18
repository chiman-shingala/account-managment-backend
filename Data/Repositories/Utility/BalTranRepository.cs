using Acc.Data.Interfaces.IUtility;
using Acc.Data.Repository.Interface;
using Acc.Shared.Dtos;

namespace Acc.Data.Repositories.Utility
{
	public class BalTranRepository : IBalTranRepository
	{
		private readonly IDRepository _dRepository;

		public BalTranRepository(IDRepository dRepository)
		{
			_dRepository = dRepository;
		}
		public async Task<int> StockTran(BalTranDto balTran)
		{
			return await _dRepository.ExecuteAsyncQuery("usp_StockTran", balTran);
		}
		public async Task<int> BalTran(BalTranDto balTran)
		{
			return await _dRepository.ExecuteAsyncQuery("usp_BalTran", balTran);
		}		
	}
}
