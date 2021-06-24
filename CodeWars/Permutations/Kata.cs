using System.Collections.Generic;
using System.Linq;

namespace CodeWars.Permutations
{
	public class Kata
	{
		public static List<string> SinglePermutations(string s)
		{
			return s.Length < 2 ?
				new List<string> { s } :
				SinglePermutations(s[1..])
					.SelectMany(p => Enumerable
						.Range(0, p.Length + 1)
						.Select((_, i) => p[..i] + s[0] + p[i..])
					)
					.Distinct()
					.ToList();
		}
	}
}
