using System;
using System.Linq;

namespace CodeWars.SupermarketQueue
{
	public class Kata
	{
		public static long QueueTime(int[] customers, int n)
		{
			var till = new int[n];

			for (var i = 0; i < customers.Length; i++)
			{
				var minIndex = Array.IndexOf(till, till.Min());
				till[minIndex] += customers[i];
			}

			return till.Max();
		}
	}
}
