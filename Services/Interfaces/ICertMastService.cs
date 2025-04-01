using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Interfaces
{
	public  interface ICertMastService
	{
		Task<List<CertMastDto>> GetAllCert();
		Task<int> AddCertMast(CertMastDto certMast);
		Task<int> UpdateCertMast(CertMastDto certMast);
		Task<int> DeleteCurrent(short Cr_Code);
	}
}
