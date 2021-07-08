using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Anagrams
{
	public class Kata
	{
		public static List<string> Anagrams(string word, List<string> words)
		{
			word = string.Join("", word.OrderBy(ch => ch));

			return words
				.Where(w => string.Join("", w.OrderBy(ch => ch)) == word)
				.ToList();
		}
	}
}
