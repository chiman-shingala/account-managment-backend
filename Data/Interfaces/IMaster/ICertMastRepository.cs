using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Interfaces.IMaster
{
	public interface ICertMastRepository
	{
		Task<List<CertMastDto>> GetAllCertMast();
		Task<int> AddCertMast(CertMastDto certMast);
		Task<int> UpdateCertMast(CertMastDto certMast);
		Task<int> DeleteCertMast(short Cr_Code);
	}
}
