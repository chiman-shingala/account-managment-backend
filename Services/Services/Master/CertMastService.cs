using Acc.Data.Interfaces.IMaster;
using Acc.Services.Interfaces.Master;
using Acc.Shared.Dtos;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Services.Master
{
	public  class CertMastService : ICertMastService
	{
		private readonly ICertMastRepository _certMast;

		public CertMastService(ICertMastRepository certMast)
		{
			_certMast = certMast;
		}
		public async Task<List<CertMastDto>> GetAllCert()
		{
			return await _certMast.GetAllCertMast();
		}
		public async Task<int> AddCertMast(CertMastDto certMast)
		{
			return await _certMast.AddCertMast(certMast);
		}
		public async Task<int> UpdateCertMast(CertMastDto certMast)
		{
			return await _certMast.UpdateCertMast(certMast);
		}
		public async Task<int> DeleteCurrent(short Cr_Code)
		{
			return await _certMast.DeleteCertMast(Cr_Code);
		}
	}
}
