using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.SquaresPerimeter
{
	public class Kata
	{
		public static BigInteger Perimeter(BigInteger n)
		{
			var i = new BigInteger(2);
			var s0 = new BigInteger(1);
			var s1 = new BigInteger(1);
			
			var result = s0 + s1;
			while (i <= n)
			{
				result += s0 + s1;

				s1 = s0 + s1;
				s0 = s1 - s0;

				i += 1;
			}
			return 4 * result;
		}
	}
}
