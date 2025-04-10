using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Interfaces.Master
{
	public interface IPropertyMastService
	{
		Task<List<PropertyMastDto>> GetAllPropertyMast();
		Task<int> AddPropertyMastMast(PropertyMastDto propertyMast);
		Task<int> UpdatePropertyMastMast(PropertyMastDto propertyMast);
		Task<int> DeletePropertyMast(string PropId);
	}
}
