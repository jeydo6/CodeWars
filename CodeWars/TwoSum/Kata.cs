using System;
using System.Linq;

namespace CodeWars.TwoSum
{
	public class Kata
	{
		public static int[] TwoSum(int[] numbers, int target)
		{
			return numbers
				.Select((n, i) => new int[] { i, Array.IndexOf(numbers, target - n, i + 1) })
				.First(arr => arr[1] > 0);
		}
	}
}
