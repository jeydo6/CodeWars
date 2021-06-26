using System.Collections.Generic;
using System.Linq;

namespace CodeWars.TheObservedPin
{
	public class Kata
	{
		private static readonly Dictionary<char, string[]> _pinNeighbours = new Dictionary<char, string[]>
		{
			['1'] = new string[] { "1", "2", "4" },
			['2'] = new string[] { "1", "2", "3", "5" },
			['3'] = new string[] { "2", "3", "6" },
			['4'] = new string[] { "1", "4", "5", "7" },
			['5'] = new string[] { "2", "4", "5", "6", "8" },
			['6'] = new string[] { "3", "5", "6", "9" },
			['7'] = new string[] { "4", "7", "8" },
			['8'] = new string[] { "5", "7", "8", "9", "0" },
			['9'] = new string[] { "6", "8", "9" },
			['0'] = new string[] { "8", "0" },
		};

		public static List<string> GetPINs(string observed)
		{
			return observed.Length < 1 ?
				new List<string> { observed } :
				GetPINs(observed[1..])
					.SelectMany(p => _pinNeighbours[observed[0]].Select(v => v + p))
					.Distinct()
					.OrderBy(p => p)
					.ToList();
		}
	}
}
