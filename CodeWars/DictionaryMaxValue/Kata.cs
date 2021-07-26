using System.Collections.Generic;
using System.Linq;

namespace CodeWars.DictionaryMaxValue
{
	public class Kata
	{
		public static int GetMaxValueKey(IDictionary<int, int> dictionary)
		{
			return dictionary
				.OrderByDescending(kvp => kvp.Value)
				.First().Key;
		}
	}
}
