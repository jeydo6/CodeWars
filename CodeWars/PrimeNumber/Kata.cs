using System;
using System.Linq;

namespace CodeWars.PrimeNumber
{
	public class Kata
	{
		public static bool IsPrime(int n)
		{
			if (n < 2)
			{
				return false;
			}

			var m = (int)Math.Sqrt(n);
			for (var i = 2; i <= m; i++)
			{
				if (n % i == 0)
				{
					return false;
				}
			}

			return true;
		}
	}
}
