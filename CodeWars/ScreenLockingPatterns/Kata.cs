using System.Collections.Generic;
using System.Numerics;

namespace CodeWars.ScreenLockingPatterns
{
	public class Kata
	{
		private static readonly IDictionary<string, string> _restricted = new Dictionary<string, string>()
		{
			["AC"] = "B",
			["CA"] = "B",
			["DF"] = "E",
			["FD"] = "E",
			["GI"] = "H",
			["IG"] = "H",
			["AG"] = "D",
			["GA"] = "D",
			["BH"] = "E",
			["HB"] = "E",
			["CI"] = "F",
			["IC"] = "F",
			["AI"] = "E",
			["IA"] = "E",
			["CG"] = "E",
			["GC"] = "E"
		};

		public static int CountPatternsFrom(char start, int length)
		{
			if (length < 2)
			{
				return length;
			}

			var count = 0;

			var stack = new Stack<string>();
			stack.Push($"{start}");

			while (stack.Count > 0)
			{
				var pattern = stack.Pop();
				if (pattern.Length == length)
				{
					count++;
				}
				else
				{
					foreach (var next in "ABCDEFGHI")
					{
						var key = $"{pattern[^1]}{next}";
						if (
							next != pattern[^1] &&
							!pattern.Contains(next) &&
							(!_restricted.ContainsKey(key) || pattern.Contains(_restricted[key]))
						)
						{
							stack.Push($"{pattern}{next}");
						}
					}
				}
			}
			return count;
		}
	}
}
