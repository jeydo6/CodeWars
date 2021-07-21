using System;
using System.Linq;

namespace CodeWars.CamelCase
{
	public class Kata
	{
		public static string CamelCase(string str)
		{
			if (string.IsNullOrEmpty(str))
			{
				return "";
			}

			return string.Concat(str
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(w => $"{char.ToUpper(w[0])}{w[1..].ToLower()}")
			);
		}
	}
}
