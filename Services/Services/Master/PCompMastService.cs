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
	public class PCompMastService : IPCompMastService
	{
		private readonly IPCompMastRepository _pCompMast;

		public PCompMastService(IPCompMastRepository pCompMast)
		{
			_pCompMast = pCompMast;
		}		
		public async Task<int> AddPCompMast(PCompMastDto pCompMast)
		{
			return await _pCompMast.AddPCompMast(pCompMast);
		}
		public async Task<int> UpdatePCompMast(PCompMastDto pCompMast)
		{
			return await _pCompMast.UpdatePCompMast(pCompMast);
		}
		public async Task<int> DeletePCompMast(string P_Code, int Acyear, string Comp_Code)
		{
			return await _pCompMast.DeletePCompMast(P_Code, Acyear, Comp_Code);
		}

		//party detail save button implementation pending
		public async Task<string> SaveParAsync(SaveParRequestDto request)
		{			
			await _pCompMast.SaveParMast(request.ParMast);

			// Step 3: Save Comp Mast
			await _pCompMast.AddPCompMast(request.PCompMast);

			// Step 4: Save Par Persons
			await _pCompMast.SaveParPersonsAsync(request.ParPersons);
			return "Saved Sucessfully";
		}
		private async Task<string> ValidateAndGeneratePCodeAsync(SaveParRequestDto request)
		{
			var parMast = request.ParMast;

			if (parMast.AcYear == 0)
				throw new Exception("Acc. Year is required.");

			if (string.IsNullOrWhiteSpace(parMast.P_Name))
				throw new Exception("Party Name is required.");

			if (string.IsNullOrWhiteSpace(parMast.Gr_Code))
				throw new Exception("Group Code is required.");

			if (string.IsNullOrWhiteSpace(parMast.P_Type))
				throw new Exception("Party Type is required.");

			bool hasOpeningAmount = (parMast.Oamount != 0 || parMast.OamountL != 0);

			if (hasOpeningAmount)
			{
				if (string.IsNullOrWhiteSpace(parMast.CnCy) || parMast.Conv == 0)
					throw new Exception("Currency and Conversion are required when opening amounts are set.");
			}

			if (parMast.Oamount != 0 && parMast.OamountL != 0)
				throw new Exception("Only one type of opening is allowed per party.");

			// 7. Generate Party Code if needed
			//if (!string.IsNullOrWhiteSpace(parMast.P_Name) && string.IsNullOrWhiteSpace(parMast.P_Code))
			//{
			//	// Assuming this repository method exists just like your old _BOParMast.ParMastNextCode(...)
			//	string nextCode = await _parRepository.GetNextParMastCode(
			//		parMast.Gr_Code.Substring(0, 1),
			//		parMast.AcYear,
			//		parMast.Comp_Code
			//	);

			//	return nextCode;
			//}

			if (string.IsNullOrWhiteSpace(parMast.P_Code))
				throw new Exception("Party Code is required.");

			return parMast.P_Code;
		}
	}
}
