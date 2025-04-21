using Acc.Data.Interfaces.IMaster;
using Acc.Data.Repository.Interface;
using Acc.Shared.Dtos;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Repositories.Master
{
	public class GirdMastRepository : IGirdMastRepository
	{
		private readonly IDRepository _dRepository;

		public GirdMastRepository(IDRepository dRepository)
		{
			_dRepository = dRepository;
		}
		public async Task<List<GirdMastDto>> GetAllGridMast()
		{
			return await _dRepository.GetAll<GirdMastDto>("SP_MastGirdMastFill");
		}
		public async Task<int> AddGridMast(GirdMastDto girdMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_GirdMastSave", girdMast);
		}
		public async Task<int> UpdateGridMast(GirdMastDto girdMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_GirdMastSave", girdMast);
		}
		public async Task<int> DeleteGridMast(string Gr_Code)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_UtilGirdMastDel", new { Gr_Code });
		}
	}
}
