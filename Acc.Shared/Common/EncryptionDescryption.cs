using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.Services.Common
{
	public static class EncryptionDescryption
	{
		public static string Encode_Decode(string pStr, string pStrToEncodeOrDecode)
		{
			int IntPos;
			string StrPass;
			string StrECode;
			string StrDCode;
			char ChrSingle;

			StrECode = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
			StrDCode = ")(*&^%$#@!";

			for (int IntLen = 1; IntLen <= 52; IntLen++)
			{
				StrDCode = StrDCode + (Char)(IntLen + 160);
			}

			StrPass = "";
			for (int IntCnt = 0; IntCnt <= pStr.Trim().Length - 1; IntCnt++)
			{
				ChrSingle = char.Parse(pStr.Substring(IntCnt, 1));
				if (pStrToEncodeOrDecode == "E")
				{
					IntPos = StrECode.IndexOf(ChrSingle, 0);
				}
				else
				{
					IntPos = StrDCode.IndexOf(ChrSingle, 0);
				}
				if (pStrToEncodeOrDecode == "E")
				{
					StrPass = StrPass + StrDCode.Substring(IntPos, 1);
				}
				else
				{
					StrPass = StrPass + StrECode.Substring(IntPos, 1);
				}
			}
			return StrPass;
		}
	}
}
