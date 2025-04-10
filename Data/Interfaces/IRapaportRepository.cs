using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Interfaces
{
	public interface IRapaportRepository
	{
		Task<double> FindRap(string sCode, int qCode, int cCode, int szCode);
		Task<double> FindDisc(string sCode, int qCode, int cCode, int szCode);
		Task<double> FindFluoDisc(string sCode, int qCode, int cCode, int szCode, int flCode);
		Task<double> FindCutDisc(string sCode, int qCode, int cCode, int szCode, int ctCode);
	}
}
