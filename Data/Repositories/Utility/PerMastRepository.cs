using Acc.Data.Interfaces.IUtility;
using Acc.Data.Repository.Interface;
using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Repositories.Utility
{
	public class PerMastRepository : IPerMastRepository
	{
		private readonly IDRepository _dRepository;

		public PerMastRepository(IDRepository dRepository)
		{
			_dRepository = dRepository;
		}
		public async Task<List<PerMastDto>> GetAllPerMast()
		{
			return await _dRepository.GetAll<PerMastDto>("SP_UtilFrmPerMast");
		}
	}
}
