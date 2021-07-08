using System;
using System.Linq;

namespace CodeWars.BurrowsWheelerTransformation
{
	public class Kata
	{
		public static (string Word, int Index) Encode(string s)
		{
			if (s.Length == 0)
			{
				return ("", 0);
			}

			var words = new string[s.Length];

			words[0] = s;
			for (var i = 1; i < s.Length; i++)
			{
				words[i] = s[i..] + s[..i];
			}

			Array.Sort(words, StringComparer.Ordinal);

			var word = string.Join("", words
				.Select(w => w[s.Length - 1])
			);

			var index = Array.FindIndex(words, w => w == s);

			return (word, index);
		}

		public static string Decode(string s, int i)
		{
			if (s.Length == 0)
			{
				return "";
			}

			var lastColumn = s.ToCharArray()
				.Select(ch => ch.ToString())
				.ToArray();

			var zipped = new string[s.Length];
			while (true)
			{
				zipped = lastColumn
					.Zip(zipped, (f, l) => f + l)
					.OrderBy(ch => ch, StringComparer.Ordinal)
					.ToArray();

				if (zipped[i].Length == s.Length)
				{
					break;
				}
			}

			return zipped[i];
		}
	}
}
