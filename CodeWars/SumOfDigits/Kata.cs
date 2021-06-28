using System.Collections.Generic;
using System.Linq;

namespace CodeWars.SumOfDigits
{
	public class Kata
	{
		public static int DigitalRoot(long n)
		{
			var stack = new Stack<long>();
			stack.Push(n);

			while (stack.Count > 0)
			{
				var result = stack
					.Pop()
					.ToString()
					.Select(ch => ch - '0')
					.Sum();

				if (result < 10)
				{
					return result;
				}
				else
				{
					stack.Push(result);
				}
			}

			return 0;
		}
	}
}
