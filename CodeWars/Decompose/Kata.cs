using System.Collections.Generic;
using System.Linq;

namespace CodeWars.Decompose
{
	public class Kata
	{
		public string decompose(long n)
		{
			var result = new Stack<long>();
			result.Push(n);

			var target = 0L;
			while (result.Count > 0)
			{
				var current = result.Pop();
				target += current * current;

				for (var i = current - 1; i > 0; i--)
				{
					if (target - (i * i) >= 0 && !result.Contains(i))
					{
						target -= i * i;
						result.Push(i);

						if (target == 0)
						{
							var ordered = result.OrderBy(x => x).ToArray();
							return string.Join(" ", ordered);
						}
					}
				}
			}

			return null;
		}
	}
}
