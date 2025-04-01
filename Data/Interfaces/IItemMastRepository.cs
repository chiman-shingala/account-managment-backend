using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Data.Interfaces
{
	public interface IItemMastRepository
	{
		Task<List<ItemMastDto>> GetAllItemMast();
		Task<int> AddItemMast(ItemMastDto itemMast);
		Task<int> UpdateItemMast(ItemMastDto itemMast);
		Task<int> DeleteItemMast(string I_Code);
	}
}
