using System;
using System.Linq;

namespace CodeWars.SimplePigLatin
{
	public class Kata
	{
		public static string PigIt(string str)
		{
			return string.Join(" ", str
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(w =>w.All(ch => char.IsLetter(ch)) ? $"{w[1..]}{w[0]}ay" : w)
			);
		}
	}
}
