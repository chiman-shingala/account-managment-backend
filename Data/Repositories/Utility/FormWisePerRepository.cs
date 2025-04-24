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
	public class FormWisePerRepository : IFormWisePerRepository	
	{
		private readonly IDRepository _dRepository;

		public FormWisePerRepository(IDRepository dRepository)
		{
			_dRepository = dRepository;
		}
		public async Task<List<PerMastDto>> GetAllFormWisePer(string Form_Name)
		{
			return await _dRepository.GetAll<PerMastDto>("usp_FormWisePerDisp", new { Form_Name });
		}
		public async Task<List<PerMastDto>> GetAllFormPer(string User_Name)
		{
			return await _dRepository.GetAll<PerMastDto>("SP_GetAllFrmPer", new { User_Name });
		}
	}
}
