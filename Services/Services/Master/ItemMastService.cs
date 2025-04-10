using Acc.Data.Interfaces.IMaster;
using Acc.Services.Interfaces.Master;
using Acc.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Services.Master
{
	public class ItemMastService : IItemMastService
	{
		private readonly IItemMastRepository _itemMast;

		public ItemMastService(IItemMastRepository itemMast)
		{
			_itemMast = itemMast;
		}
		public async Task<List<ItemMastDto>> GetAllItem()
		{
			return await _itemMast.GetAllItemMast();
		}
		public async Task<int> AddItem(ItemMastDto itemMast)
		{
			return await _itemMast.AddItemMast(itemMast);
		}
		public async Task<int> UpdateItem(ItemMastDto itemMast)
		{
			return await _itemMast.UpdateItemMast(itemMast);
		}
		public async Task<int> DeleteItem(string I_Code)
		{
			return await _itemMast.DeleteItemMast(I_Code);
		}
	}
}
