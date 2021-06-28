using System.Linq;

namespace CodeWars.DuplicateEncoder
{
	public class Kata
	{
		public static string DuplicateEncode(string word)
		{
			var dict = word
				.ToLower()
				.GroupBy(ch => ch)
				.ToDictionary(g => g.Key, g => g.Count());

			return string.Join("", word
				.ToLower()
				.Select(ch => dict[ch] > 1 ? ")" : "(")
			);
		}
	}
}
