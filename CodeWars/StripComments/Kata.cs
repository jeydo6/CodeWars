using System;
using System.Linq;

namespace CodeWars.StripComments
{
	public class Kata
	{
		public static string StripComments(string text, string[] commentSymbols)
		{
			return string.Join("\n", text.Split("\n")
				.Select(l => l
					.Split(commentSymbols, StringSplitOptions.None)[0]
					.TrimEnd()
				)
			);
		}
	}
}
