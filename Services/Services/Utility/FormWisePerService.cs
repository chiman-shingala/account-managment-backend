using Acc.Data.Interfaces.IUtility;
using Acc.Services.Interfaces.Utility;
using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Services.Utility
{
	public class FormWisePerService : IFormWisePerService
	{
		private readonly IFormWisePerRepository _formWisePer;

		public FormWisePerService(IFormWisePerRepository formWisePer)
		{
			_formWisePer = formWisePer;
		}
		public async Task<List<PerMastDto>> GetAllFormWisePer(string Form_Name)
		{
			return await _formWisePer.GetAllFormWisePer(Form_Name);
		}
	}
}
