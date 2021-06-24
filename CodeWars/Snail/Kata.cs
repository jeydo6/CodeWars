using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars.Snail
{
	public class Kata
	{
		public static int[] Snail(int[][] array)
		{
			if (array.Length == 0)
			{
				return Array.Empty<int>();
			}
			else if (array.Length == 1)
			{
				return array[0];
			}
			else
			{
				var result = new List<int>();

				// top
				result.AddRange(array[0]);

				// right
				result.AddRange(array[1..].Select(c => c[^1]));

				// bottom
				result.AddRange(array[^1][..^1].Reverse().ToArray());

				// left
				result.AddRange(array[1..^1].Select(c => c[0]).Reverse());

				// recursive
				result.AddRange(
					Snail(array[1..^1].Select(c => c[1..^1]).ToArray())
				);

				return result.ToArray();
			}
		}
	}
}
