using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars.SumOfDivided
{
	public class Kata
	{
		public static string SumOfDivided(int[] list)
		{
			string result = "";

			var primes = new List<int>();

			for (int i = 2; i <= list.Max(Math.Abs); i++)
			{
				if (primes.All(p => i % p != 0) && list.Any(p => p % i == 0))
				{
					var j = list.Where(p => Math.Abs(p) % i == 0).Sum();

					primes.Add(i);
					result += $"({i} {j})";
				}
			}

			return result;
		}
	}
}
