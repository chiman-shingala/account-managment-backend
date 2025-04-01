using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Interfaces
{
	public interface IPropertyMastRepository
	{
		Task<List<PropertyMastDto>> GetAllPropertyMast();
		Task<int> AddPropertyMast(PropertyMastDto propertyMast);
		Task<int> UpdatePropertyMast(PropertyMastDto propertyMast);
		Task<int> DeletePropertyMast(string PropId);
	}
}
