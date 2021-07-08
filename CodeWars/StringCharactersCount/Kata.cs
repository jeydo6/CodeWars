using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.StringCharactersCount
{
	public class Kata
	{
		public static Dictionary<char, int> Count(string str)
		{
			return str
				.GroupBy(ch => ch)
				.ToDictionary(g => g.Key, g => g.Count());
		}
	}
}
