using Acc.Data.Interfaces;
using Acc.Services.Interfaces;
using Acc.Shared.Dtos;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Services
{
	public class SizeMastService : ISizeMastService
	{
		private readonly ISizeMastRepository _sizeMast;

		public SizeMastService(ISizeMastRepository sizeMast)
		{
			_sizeMast = sizeMast;
		}
		public async Task<List<SizeMastDto>> GetAllSize()
		{
			return await _sizeMast.GetAllSize();
		}
		public async Task<int> AddSize(SizeMastDto sizeMast)
		{
			return await _sizeMast.AddSize(sizeMast);
		}
		public async Task<int> UpdateSize(SizeMastDto sizeMast)
		{
			return await _sizeMast.UpdateSize(sizeMast);
		}
		public async Task<int> DeleteSize(short SZ_Code)
		{
			return await _sizeMast.DeleteSize(SZ_Code);
		}
	}
}
