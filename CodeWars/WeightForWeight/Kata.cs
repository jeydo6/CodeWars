using System;
using System.Linq;

namespace CodeWars.WeightForWeight
{
	public class Kata
	{
		public static string OrderWeight(string str)
		{
			return string.Join(" ", str
				.Split(" ")
				.OrderBy(w => w.Sum(ch => ch - '0'))
				.ThenBy(w => w)
			);
		}

		public static int TrailingZeros(int n)
		{
			return Enumerable
				.Range(1, (int)Math.Log(n, 5))
				.Sum(i => (int)(n / Math.Pow(5, i)));
		}
	}
}
