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
	public class StonNatRepository : IStonNatRepository
	{
		private readonly IDRepository _dRepository;

		public StonNatRepository(IDRepository dRepository)
		{
			_dRepository = dRepository;
		}
		public async Task<List<StonNatDto>> GetAllStone()
		{
			return await _dRepository.GetAll<StonNatDto>("SP_MastStonNatFill");
		}
		public async Task<int> AddStone(StonNatDto stonNat)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_StonNatSave", stonNat);
		}
		public async Task<int> UpdateStone(StonNatDto stonNat)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_StonNatSave", stonNat);
		}
		public async Task<int> DeleteStone(string SN_Code)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_UtilStonNatDel", new { SN_Code });
		}
	}
}
