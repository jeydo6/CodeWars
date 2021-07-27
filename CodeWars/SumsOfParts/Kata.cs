using System.Collections.Generic;
using System.Linq;

namespace CodeWars.SumsOfParts
{
	public class Kata
	{
		public static int[] PartsSums(int[] list)
		{
			return list
				.Aggregate(
					new List<int> { list.Sum() },
					(acc, i) =>
					{
						acc.Add(acc[^1] - i);
						return acc;
					}
				)
				.ToArray();
		}
	}
}
