using System.Linq;

namespace CodeWars.NextSmallerNumber
{
	public class Kata
	{
		public static long NextBiggerNumber(long n)
		{
			var s = $"{n}";

			if (n > 0 && s.Length == 1)
			{
				return -1;
			}

			for (int i = s.Length - 2; i >= 0; i--)
			{
				if (s[i..] != string.Concat(s[i..].OrderBy(x => x)))
				{
					var t = string.Concat(s[i..].OrderByDescending(x => x));
					var c = t.First(x => x < s[i]);

					return i == 0 & c == '0' ? -1 : long.Parse(s[..i] + c + string.Concat(t.Where((x, y) => y != t.IndexOf(c))));
				}
			}
			return -1;
		}
	}
}
