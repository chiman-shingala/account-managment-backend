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
	public class PropertyMastRepository : IPropertyMastRepository
	{
		private readonly IDRepository _dRepository;

		public PropertyMastRepository(IDRepository dRepository)
		{
			_dRepository = dRepository;
		}
		public async Task<List<PropertyMastDto>> GetAllPropertyMast()
		{
			return await _dRepository.GetAll<PropertyMastDto>("SP_MastPropertyMastFill");
		}
		public async Task<int> AddPropertyMast(PropertyMastDto propertyMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_PropertyMastSave", propertyMast);
		}
		public async Task<int> UpdatePropertyMast(PropertyMastDto propertyMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_PropertyMastSave", propertyMast);
		}
		public async Task<int> DeletePropertyMast(string PropId)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_UtilPropertyMastDel", new { PropId });
		}
	}
}
