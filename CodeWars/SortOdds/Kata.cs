using System.Collections.Generic;
using System.Linq;

namespace CodeWars.SortOdds
{
	public class Kata
	{
		public static int[] SortArray(int[] array)
		{
			var odds = new Queue<int>(
				array.Where(i => i % 2 == 1).OrderBy(i => i)
			);

			return array
				.Select(i => i % 2 == 1 ? odds.Dequeue() : i)
				.ToArray();
		}
	}
}
