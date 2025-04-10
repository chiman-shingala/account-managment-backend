using Acc.Data.Interfaces.IMaster;
using Acc.Services.Interfaces;
using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Services
{
	public class PropertyMastService : IPropertyMastService
	{
		private readonly IPropertyMastRepository _propertyMast;

		public PropertyMastService(IPropertyMastRepository propertyMast)
		{
			_propertyMast = propertyMast;
		}
		public async Task<List<PropertyMastDto>> GetAllPropertyMast()
		{
			return await _propertyMast.GetAllPropertyMast();
		}
		public async Task<int> AddPropertyMastMast(PropertyMastDto propertyMast)
		{
			return await _propertyMast.AddPropertyMast(propertyMast);
		}
		public async Task<int> UpdatePropertyMastMast(PropertyMastDto propertyMast)
		{
			return await _propertyMast.UpdatePropertyMast(propertyMast);
		}
		public async Task<int> DeletePropertyMast(string PropId)
		{
			return await _propertyMast.DeletePropertyMast(PropId);
		}
	}
}
