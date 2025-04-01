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
	public class CertMastRepository :ICertMastRepository
	{
		private readonly IDRepository _dRepository;

		public CertMastRepository(IDRepository dRepository)
		{
			_dRepository = dRepository;
		}
		public async Task<List<CertMastDto>> GetAllCertMast()
		{
			return await _dRepository.GetAll<CertMastDto>("SP_MastCertMastFill");
		}
		public async Task<int> AddCertMast(CertMastDto certMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_CertMastSave", certMast);
		}
		public async Task<int> UpdateCertMast(CertMastDto certMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_CertMastSave", certMast);
		}
		public async Task<int> DeleteCertMast(short Cr_Code)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_UtilCertMastCertDel", new { Cr_Code });
		}
	}
}
