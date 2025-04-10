using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Interfaces.Master
{
	public interface IItemMastService
	{
		Task<List<ItemMastDto>> GetAllItem();
		Task<int> AddItem(ItemMastDto itemMast);
		Task<int> UpdateItem(ItemMastDto itemMast);
		Task<int> DeleteItem(string I_Code);
	}
}
