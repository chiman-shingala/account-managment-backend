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
	public  class ItemMastRepository : IItemMastRepository
	{
		private readonly IDRepository _dRepository;

		public ItemMastRepository(IDRepository dRepository)
		{
			_dRepository = dRepository;
		}
		public async Task<List<ItemMastDto>> GetAllItemMast()
		{
			return await _dRepository.GetAll<ItemMastDto>("SP_MastItemMastFill");
		}
		public async Task<int> AddItemMast(ItemMastDto itemMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_ItemMastSave", itemMast);
		}
		public async Task<int> UpdateItemMast(ItemMastDto itemMast)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_ItemMastSave", itemMast);
		}
		public async Task<int> DeleteItemMast(string I_Code)
		{
			return await _dRepository.ExecuteAsyncQuery("SP_UtilItemMastDel", new { I_Code });
		}
	}
}
