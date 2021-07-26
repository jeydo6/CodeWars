using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.ProperFractions
{
	public class Kata
	{
		public static long ProperFractions(long n)
		{
			if (n == 1)
			{
				return 0;
			}

			var result = n;

			for (var i = 2L; i < Math.Sqrt(n); i++)
			{
				if (n % i == 0)
				{
					while (n % i == 0)
					{
						n /= i;
					}

					result -= result / i;
				}
			}

			if (n > 1)
			{
				result -= result / n;
			}

			return result;
		}
	}
}
