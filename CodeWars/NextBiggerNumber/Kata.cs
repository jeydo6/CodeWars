using System.Linq;

namespace CodeWars.NextBiggerNumber
{
	public class Kata
	{
		public static long NextBiggerNumber(long n)
		{
			var str = GetNumbers(n);
			for (long i = n + 1; i <= long.Parse(str); i++)
			{
				if (GetNumbers(i) == str)
				{
					return i;
				}
			}
			return -1;
		}

		public static string GetNumbers(long number)
		{
			return string.Join("", number.ToString().ToCharArray().OrderBy(x => x));
		}
	}
}
