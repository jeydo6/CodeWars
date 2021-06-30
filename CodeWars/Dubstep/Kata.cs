using System;

namespace CodeWars.Dubstep
{
	public class Kata
	{
		public static string SongDecoder(string input)
		{
			return string.Join(" ", input
					.Split("WUB", StringSplitOptions.RemoveEmptyEntries)
				)
				.Trim();
		}
	}
}
