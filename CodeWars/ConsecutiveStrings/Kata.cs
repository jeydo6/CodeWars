using System.Linq;

namespace CodeWars.ConsecutiveStrings
{
	public class Kata
	{
		public static string LongestConsec(string[] strarr, int k)
		{
			if (strarr.Length == 0 || strarr.Length < k || k <= 0)
			{
				return "";
			}

			return Enumerable
				.Range(0, strarr.Length - k + 1)
				.Select(i => string.Join("", strarr.Skip(i).Take(k)))
				.OrderByDescending(s => s.Length)
				.First();
		}
	}
}
